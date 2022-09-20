namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			string str = count.ToString();
			int last = int.Parse(str.Substring(str.Length - 1, 1));
			int preLast = 0;
			if (count > 9)
			{
				preLast = int.Parse(str.Substring(str.Length - 2, 1));
			}
			if (last > 1 && last < 5 && preLast != 1)
			{
				return "рубля";
			}
			else if (last == 1 && preLast != 1)
			{
				return "рубль";
			}
			else
			{
				return "рублей";

			}
		}
	}
}