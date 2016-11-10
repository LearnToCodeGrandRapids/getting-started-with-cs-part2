using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Digits
{
	[TestFixture()]
	public class Test
	{
		[TestCase(123, new int[] { 1, 2, 3 })]
		[TestCase(54321, new int[] { 1, 2, 3 })]
		[TestCase(11011, new int[] { 1, 2, 3 })]
		public void TestCase(int input, int[] expected)
		{
			var digits = new List<int>();

			// Write a function that takes an integer and returns a list of its digits.

			Assert.IsTrue(expected.SequenceEqual(digits));
		}
	}
}
