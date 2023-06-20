using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _dbContext;

        public UserController(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("register")]
        public IActionResult Register([FromForm]User user)
        {
            var existingUser = _dbContext.User.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser != null)
            {
                return BadRequest("Email already registered.");
            }

            _dbContext.User.Add(user);
            _dbContext.SaveChanges();

            return Ok("Registration successful.");
        }

        [HttpPost("login")]
        public IActionResult Login([FromForm] User user)
        {
            var existingUser = _dbContext.User.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (existingUser == null)
            {
                return BadRequest("Invalid email or password.");
            }

            return Ok("Login successful.");
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            string connectionString = "Data Source=.;Initial Catalog=assignment;User Id=sa;Password=root123.;"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 1; i <= 30; i++)
                {
                    string title = $"Article {i}";
                    string content = $"Content of Article {i}";
                    int authorId = GetRandomUserId(connection); 

                    string insertQuery = $"INSERT INTO Article (Title, Content, AuthorId) VALUES (@title, @content, @author)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@content", content);
                        command.Parameters.AddWithValue("@author", authorId);
                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }

            return Ok("Login successful.");
        }

        private static int GetRandomUserId(SqlConnection connection)
        {
            string selectQuery = "SELECT id FROM [User] ORDER BY NEWID() OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }

    }

}
