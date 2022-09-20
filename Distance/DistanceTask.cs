using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double distanceAtoDot = Math.Sqrt((Math.Pow((x - ax), 2) + (Math.Pow((y - ay), 2))));
			double distanceBtoDot = Math.Sqrt((Math.Pow((x - bx), 2) + (Math.Pow((y - by), 2))));
			double squareofABC = (distanceAtoDot * distanceBtoDot) / 2;
			double distanceAtoB = Math.Sqrt((Math.Pow((bx - ax), 2)) + (Math.Pow((by - ay), 2)));
			double heightOfABC = 2 * squareofABC / distanceAtoB;
			double roundAB = Math.Round(distanceAtoB);
			double roundADot = Math.Round(distanceAtoDot);
			double roundBDot = Math.Round(distanceBtoDot);
            if (roundADot + roundBDot == roundAB) { return 0.0; }
            else
            {
				if (distanceAtoDot > distanceBtoDot) { return Math.Min(distanceBtoDot, heightOfABC); }
				else return Math.Min(distanceAtoDot, heightOfABC);
			}
		}
	}
}