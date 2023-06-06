const welcome = document.querySelector('.welcome')
const btn = document.querySelector('.btn')
const hiddenSections = document.querySelector('.hidden-sections')

welcome.addEventListener('click', (event) => {
  welcome.innerText = 'Have a Good Time!';
})

btn.addEventListener('click', (event) => {
  hiddenSections.className = 'sections';
})

