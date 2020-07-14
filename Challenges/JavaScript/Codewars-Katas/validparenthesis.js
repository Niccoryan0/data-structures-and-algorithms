// Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.

function validParentheses(parens){
  var stack = [];
  for (let i = 0; i < parens.length; i++) {
      let item = parens[i];
      if (item === '(') {
        stack.push(')');
      } else {
        if (item !== stack.pop()) {
          return false;
      }
    }
  }
  return stack.length === 0;
};

console.log(validParentheses("()")); // true
console.log(validParentheses(")(()))")); // false
console.log(validParentheses("(")); // false
console.log(validParentheses("(())((()())())")); // true