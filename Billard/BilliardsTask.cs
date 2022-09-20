using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionRadians">Угол направления движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns></returns>
        public static double ToGradusFromRadians(double radians){
            return (radians * 180) / Math.PI; 
            }

        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
           double direction = ToGradusFromRadians(directionRadians);
            double wallInclantion = ToGradusFromRadians(wallInclinationRadians);

            double wallAngle = 90 + wallInclantion;
            double ballAngle = 180 + direction;

            double diff = wallAngle - ballAngle;
            double angle = ballAngle + 2 * diff + 360 * 5;

            angle = angle % 360;
            return (angle * Math.PI) / 180;
        }
    }
}