namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{

			while (robot.Finished == false)
			{
				MoveRight(robot, width);
				MoveDown(robot, height);
			}
				
			
		}

		public static void MoveRight(Robot robot, int width)
		{
			for (int i = 0; i < width; i++)
			{
				try { robot.MoveTo(Direction.Right); }
				catch { }
			}
		}

		public static void MoveDown(Robot robot, int height)
		{
			for (int i = 0; i < height; i++)
			{
				try { robot.MoveTo(Direction.Down); }
				catch { }
			}
		}
	}
}