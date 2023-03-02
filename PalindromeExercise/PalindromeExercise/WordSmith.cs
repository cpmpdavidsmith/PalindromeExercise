using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string word)
		{
			string reverse = "";
			for (int i = word.Length-1; i >= 0; i--)
			{
				reverse += word[i];

			}
			return word.ToLower() == reverse.ToLower();
		}
	}
}

