namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			for (int i = 0; i < width - 3; i++)
			{
				robot.MoveTo(Direction.Right);
			}
			for (int i = 0; i < height - 3; i++)
			{
				robot.MoveTo(Direction.Down);
			}
		}

		public static void MoveRight(Robot robot, int indentWidth)
        {
			for(int i = 0; i < indentWidth - 3; i++)
            {
				robot.MoveTo(Direction.Right);
            }
        }

		public static void MoveDown(Robot robot, int indentHeight)
        {
			for(int i = 0; i < indentHeight - 3; i++)
            {
				robot.MoveTo(Direction.Down);
            }
        }
	}
}