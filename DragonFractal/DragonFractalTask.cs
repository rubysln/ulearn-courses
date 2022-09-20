using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			var x = 1.0;
			var y = 0.0;
			var derivativeX = 0.0;
			var derivativey = 0.0;
			for (int i = 0; i < iterationsCount; i++)
			{
				var random = new Random(seed);
				var nextNumber = random.Next();
				if (nextNumber != 0)
				{
					derivativeX = (x * Math.Cos(Math.PI / 4) - y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2);
					derivativey = (x * Math.Sin(Math.PI / 4) + y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);
					x = derivativeX;
					y = derivativey;
				}
				else
				{
					derivativeX = (x * Math.Cos(Math.PI / 4) - y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2) + 1;
					derivativey = (x * Math.Sin(Math.PI / 4) + y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);
					x = derivativeX;
					y = derivativey;
				}
				pixels.SetPixel(x, y);
			}
		}
	}
}