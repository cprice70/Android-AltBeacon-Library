﻿using System.Linq;
using NUnit.Framework;

namespace AndroidAltBeaconLibrary.UnitTests
{
	public static class AssertEx
	{
		public static void AreEqual(string message, int expected, int actual)
		{
			Assert.AreEqual(expected, actual, message);
		}
		
		public static void AreEqual(string message, long expected, long actual)
		{
			Assert.AreEqual(expected, actual, message);
		}
		
		public static void AreEqual(string message, byte[] expected, byte[] actual)
		{
			Assert.IsTrue(actual.SequenceEqual(expected), message);
		}
		
		public static void AreEqual(string message, double expected, double actual, double delta)
		{
			Assert.AreEqual(expected, actual, delta, message);
		}
		
		public static void AreEqual(string message, object expected, object actual)
		{
			Assert.AreEqual(expected, actual, message);
		}
		
		public static void Null(string message, object anObject)
		{
			Assert.Null(anObject, message);
		}
		
		public static void NotNull(string message, object anObject)
		{
			Assert.NotNull(anObject, message);
		}
	}
}