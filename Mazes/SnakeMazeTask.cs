namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			while (true)
			{
				for (int i = 0; i < width - 3; i++)
				{
					robot.MoveTo(Direction.Right);
				}
				MoveDown(robot, width, height);
				for (int i = 0; i < width - 3; i++)
				{
					try { robot.MoveTo(Direction.Left); }
					catch { }
				}
				MoveDown(robot, width, height);
				if (robot.Finished == true)
					break;
			}
		}

		public static void MoveDown(Robot robot, int width, int height)
		{
			for (int i = 0; i < height; i++)
            {
				try { robot.MoveTo(Direction.Down); }
                catch {}
            }
        }
	}
}