namespace AdventOfCode2022.Helpers
{
	public static class FileLoader
	{
		private static string GetCurrentPath() => AppContext.BaseDirectory;


		public static List<string> ReadDummyData(string day, string part)
		{
			using var reader = new StreamReader(File.OpenRead($"..\\..\\..\\Data\\DummyDataDay{day}_{part}.txt"));

			string ln;
			var contentList = new List<string>();
			while((ln = reader.ReadLine()) != null)
			{
				contentList.Add(ln);
			}

			reader.Dispose();
			return contentList;
		}
		public static List<string> ReadDummyDataWithoutPart(string day)
		{
			using var reader = new StreamReader(File.OpenRead($"..\\..\\..\\Data\\DummyDataDay{day}.txt"));

			string ln;
			var contentList = new List<string>();
			while ((ln = reader.ReadLine()) != null)
			{
				contentList.Add(ln);
			}

			reader.Dispose();
			return contentList;
		}
		public static List<string> ReadFile(string day, string part)
		{
			using var reader = new StreamReader(File.OpenRead($"..\\..\\..\\Data\\Day{day}_{part}.txt"));

			string ln;
			var contentList = new List<string>();
			while ((ln = reader.ReadLine()) != null)
			{
				contentList.Add(ln);
			}

			reader.Dispose();
			return contentList;
		}
		public static List<string> ReadFileWithoutPart(string day)
		{
			using var reader = new StreamReader(File.OpenRead($"..\\..\\..\\Data\\Day{day}.txt"));

			string ln;
			var contentList = new List<string>();
			while ((ln = reader.ReadLine()) != null)
			{
				contentList.Add(ln);
			}

			reader.Dispose();
			return contentList;
		}
	}
}
