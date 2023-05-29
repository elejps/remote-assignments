function countAandB(input) {
  let count = 0
  for (let i = 0; i < input.length; i++) {
    if (input[i] === 'a' || input[i] === 'b') {
      count++
    }
  }
  return count
}

function toNumber(input) {
  let alphabet = ['a', 'b', 'c', 'd', 'e']
  let result = []
  for (let i = 0; i < input.length; i++) {
    for (let n = 0; n < alphabet.length; n++) {
      if (input[i] === alphabet[n]) {
        result.push(n + 1)
      }
    }
  }
  return result
}

let input1 = ['a', 'b', 'c', 'a', 'c', 'a', 'c'];
console.log(countAandB(input1));
console.log(toNumber(input1));

let input2 = ['e', 'd', 'c', 'd', 'e'];
console.log(countAandB(input2));
console.log(toNumber(input2)); 