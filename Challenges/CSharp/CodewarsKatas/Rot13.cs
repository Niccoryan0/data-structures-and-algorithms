// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

// Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

public class Kata
{
  public static string Rot13(string message)
  {
    char[] array = message.ToCharArray();
	    for (int i = 0; i < array.Length; i++)
	    {
    		int number = (int)array[i];
    		if (number >= 'a' && number <= 'z')
    		{
    		  number = number > 'm' ? number - 13 : number + 13;
    		}
    		else if (number >= 'A' && number <= 'Z')
    		{
    		  number = number > 'M' ? number - 13 : number + 13;
    		}
    		array[i] = (char)number;
	    }
	    return new string(array);
  }
}