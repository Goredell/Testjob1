using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
	[TestClass]
	public class SquareTests
	{
		[TestMethod]
		public void TestCircleSqr()
		{
			double arg1 = 10;
			Square.Answer expected = new Square.Answer(arg1 * arg1 * System.Math.PI, "Circle");

			Square.Answer result = Square.Sqr.GetSqr(arg1);

			Assert.AreEqual(expected, result);
		}
		[TestMethod]
		public void TestSqrSqr()
		{
			double arg1 = 10;
			double arg2 = 10;
			Square.Answer expected = new Square.Answer(arg1 * arg2, "Square");

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2);

			Assert.AreEqual(expected, result);
		}
		[TestMethod]
		public void TestRecSqr()
		{
			double arg1 = 10;
			double arg2 = 20;
			Square.Answer expected = new Square.Answer(arg1 * arg2, "Parallelogram");

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2);

			Assert.AreEqual(expected, result);
		}
		[TestMethod]
		public void TestTriangleSqr()
		{
			double arg1 = 2;
			double arg2 = 2;
			double arg3 = 2;
			Square.Answer expected = new Square.Answer(System.Math.Sqrt(3), "Triangle");

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2, arg3);

			Assert.AreEqual(expected, result);
		}
		[TestMethod]
		public void TestRightTriangleSqr()
		{
			double arg1 = 3;
			double arg2 = 4;
			double arg3 = 5;
			Square.Answer expected = new Square.Answer(6, "Right triangle");

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2, arg3);

			Assert.AreEqual(expected, result);
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestBrokenTriangleSqr()
		{
			double arg1 = 20;
			double arg2 = 5;
			double arg3 = 5;

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2, arg3);
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestNullCircleSqr()
		{
			double arg1 = 0;

			Square.Answer result = Square.Sqr.GetSqr(arg1);
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestNullRecSqr()
		{
			double arg1 = 0;
			double arg2 = 122;

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2);
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestNullTriangleSqr()
		{
			double arg1 = 0;
			double arg2 = 5;
			double arg3 = 5;

			Square.Answer result = Square.Sqr.GetSqr(arg1, arg2, arg3);
		}
	}
}
