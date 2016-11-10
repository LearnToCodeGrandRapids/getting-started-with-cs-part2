using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Concatenate
{
	[TestFixture()]
	public class Test
	{
		[TestCase(new int[] { 0, 1 }, new int[] { 2, 3 }, Result = 4)]
		[TestCase(new int[] { 7, 5, 3, 1 }, new int[] { 2, 3, 4 }, Result = 7)]
		[TestCase(new int[] { 1, 2, 3, 2, 1 }, new int[] { 2 }, Result = 6)]
		public int TestCase(int[] set1, int[] set2)
		{
			var list1 = new List<int>(set1);
			var list2 = new List<int>(set2);

			List<int> concatenated;

			// Write a function that concatenates two lists.

			return concatenated.Count;
		}
	}
}
