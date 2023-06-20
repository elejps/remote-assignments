using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddTransient<ICalculator, AdvancedCalculator>();
        services.AddTransient<CalculatorController>((sp) => {
            ICalculator calculator = sp.GetService<ICalculator>();
            return new CalculatorController(calculator, "-"); 
        });
        var serviceProvider = services.BuildServiceProvider();

        CalculatorController controller = serviceProvider.GetService<CalculatorController>();
        controller.Calculate(5, 1);
    }
}