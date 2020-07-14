// Jamie is a programmer, and James' girlfriend. She likes diamonds, and wants a diamond string from James. Since James doesn't know how to make this happen, he needs your help.

// Task
// You need to return a string that looks like a diamond shape when printed on the screen, using asterisk (*) characters. Trailing spaces should be removed, and every line must be terminated with a newline character (\n).

// Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.

// Examples
// A size 3 diamond:

//  *
// ***
//  *
// ...which would appear as a string of " *\n***\n *\n"

// A size 5 diamond:

//   *
//  ***
// *****
//  ***
//   *
// ...that is: " *\n ***\n*****\n ***\n *\n"

using System;

public class Diamond
{
	public static string print(int n)
	{
		if (n % 2 == 0 | n < 1){
      return null;
    }
    int middle = (n + 1) / 2;
    string diamond = "";
    for(int i = 1; i <= n; i++) {
        int j = i <= middle ? i : n - i + 1;
        diamond += new string (' ', middle-j) + new string ('*', 2*j-1) + '\n';
    }
    return diamond;
	}
}