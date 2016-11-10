using System;
using System.Collections.Generic;

namespace WordBox
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			PrintWords(new List<string>(new string[] { "Hello", "World", "in", "a", "frame" }));

			PrintWords(new List<string>(new string[] { "The", "sky", "is", "falling" }));
		}

		/// <summary>
		/// Write a function that takes a list of strings an prints them, one per line, 
		/// in a rectangular frame. For example the list ["Hello", "World", 
		/// "in", "a", "frame"] gets printed as:
		/// 
		/// *********
		/// * Hello*
		/// * World *
		/// * in    *
		/// * a*
		/// * frame *
		/// *********
		/// </summary>
		/// <param name="words">A list of words to print in a box</param>
		public static void PrintWords(List<string> words)
		{
			// insert code here
		}
	}
}
