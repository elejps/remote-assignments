function count(input) {
  let result = {};
  for (let i in input) {
    if (result.hasOwnProperty(input[i])) {
      result[input[i]]++;
    } else {
      result[input[i]] = 1;
    }
  }
  return result;
}

let input1 = ["a", "b", "c", "a", "c", "a", "x"];
console.log(count(input1));


function groupByKey(input) {
  let result = {};
  for (let i in input) {
    if (result.hasOwnProperty(input[i].key)) {
      result[input[i].key] += input[i].value;
    } else {
      result[input[i].key] = input[i].value;
    }
  }
  return result;
}

let input2 = [
  { key: "a", value: 3 },
  { key: "b", value: 1 },
  { key: "c", value: 2 },
  { key: "a", value: 3 },
  { key: "c", value: 5 },
];
console.log(groupByKey(input2));
