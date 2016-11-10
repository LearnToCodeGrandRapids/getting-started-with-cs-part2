using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LargestElement
{
	[TestFixture()]
	public class Test
	{
		[TestCase(new int[] { 0, 1 }, Result = 1)]
		[TestCase(new int[] { 7, 5, 3, 1 }, Result = 7)]
		[TestCase(new int[] { 1, 2, 3, 2, 1 }, Result = 3)]
		public int TestCase(int[] inputs)
		{
			var elements = new List<int>(inputs);

			var x = 0;

			// Write a function that returns the largest element in a list.

			return x;
		}
	}
}
