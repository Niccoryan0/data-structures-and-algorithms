// Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of n^3, the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.

// You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

// The parameter of the function findNb (find_nb, find-nb, findNb) will be an integer m and you have to return the integer n such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.

// Examples:
// findNb(1071225) --> 45
// findNb(91716553919377) --> -1
// mov rdi, 1071225
// call find_nb            ; rax <-- 45

// mov rdi, 91716553919377
// call find_nb            ; rax <-- -1

using System;
public class ASum {
	
	public static long findNb(long m) {
		  long total = 0, num = 0;
      while(total < m) {
        num += 1;
        total += (long)Math.Pow(num, 3);
      }
      return total == m ? num : -1;

      // Same idea, more concise (top answer: Azuaron, vobr, asdas123):
      // long total = 1, i = 2;
      // for(; total < m; i++) total += i * i * i;
      // return total == m ? i - 1 : -1;

      // Mathy solution (user: Mr.Relax):
      // long n = (long)Math.Floor(Math.Sqrt(2*Math.Sqrt(m)));
      // return ((n * (n + 1)) / 2) * ((n * (n + 1)) / 2) == m ? n : -1;
	}

}