class Node{
  constructor(value){
    this.value = value;
    this.children = [];
  }
}

function fizzBuzz(tree){
  let result = [];
  return fizzBuzzHelper(tree.root, result);
}

function fizzBuzzHelper(node, result){
  let string = "";
  if (node.value % 3 === 0){
    string += "Fizz";
  }
  else if (node.value % 5 === 0){
    string += 'Buzz';
  }
  else{
    string = node.value
  };
  result.push(string);
  node.children.forEach(child => {
    if(child){
      fizzBuzzHelper(child, result);
    }
  });
  return result;
}

