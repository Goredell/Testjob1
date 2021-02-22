using System;

namespace Square
{
	public struct Answer
	{
		public Answer(double sq, string fig)
		{
			square = sq;
			figure = fig;
		}
		public double square { get; }
		public string figure { get; }

		public override string ToString() => $"\nIt's a {figure}, with a square of {square}";
	}
	public static class Sqr
	{

		//Circle
		public static Answer GetSqr(double rad)
		{
			//Input check
			if (rad <= 0)
				throw new ArgumentException("All Arguments should be greater than zero");
			else
				return new Answer(Math.PI * rad * rad, "Circle");
		}


		//Triangle
		public static Answer GetSqr(double a, double b, double c)
		{
			//Input check
			if (a <= 0 || b <= 0 || c <= 0)
				throw new ArgumentException("All Arguments should be greater than zero");
			else
			{
				double[] triangle = new double[3];
				triangle[0] = a;
				triangle[1] = b;
				triangle[2] = c;


				//Ascending sorting to check if triangle is right
				for (int i = 0; i < 2; i++)
					if (triangle[i] > triangle[i + 1])
					{
						double j = triangle[i + 1];
						triangle[i + 1] = triangle[i];
						triangle[i] = j;
					}

				//Check sides length
				if ((triangle[0] + triangle[1]) <= triangle[2])
					throw new ArgumentException("One of the sides is too long, triangle can't exist");

				//Check if right triangle useing Pythagorean theorem
				double sum = triangle[0] * triangle[0] + triangle[1] * triangle[1] - triangle[2] * triangle[2];
				if (sum == 0)
				{
					//Getting square using half-product of legs
					return new Answer((triangle[0] * triangle[1]) / 2.0, "Right triangle");
				}
				else
				{
					//Getting square using three sides
					double p = (a + b + c) / 2.0;
					return new Answer(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), "Triangle");
				}
			}
		}

		//Square, rectangle, parallelepiped
		public static Answer GetSqr(double a, double b)
		{
			//Input check
			if (a <= 0 || b <= 0)
				throw new ArgumentException("All Arguments should be greater than zero");
			else
			{
				//Square check
				if (a == b)
					return new Answer(a * b, "Square");
				else
					return new Answer(a * b, "Parallelogram");
			}
		}
	}
}
