using AdventOfCode2022.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1
{
	public class Day1
	{
		private readonly List<string> fileContent;
		public Day1()
		{
			//fileContent = FileLoader.ReadDummyData("1", "1");
			fileContent = FileLoader.ReadFile("1", "1");
			Runner();
		}
		private void Runner()
		{
			Day1Part1();
			Day1Part2();
		}
		public void Day1Part2()
		{
			var list = new List<int>();
			var oneElfsCalories = 0;
			var maxLen = fileContent.Count();
			var iterator = 1;
			foreach (var line in fileContent)
			{
				if (string.IsNullOrEmpty(line))
				{
					list.Add(oneElfsCalories);
					oneElfsCalories = 0;
				}
				else
				{
					var res = 0;
					Int32.TryParse(line, out res);

					oneElfsCalories += res;
					if (iterator == maxLen)
					{
						list.Add(oneElfsCalories);
					}
				}
				iterator++;
			}
			list.Sort();
			var count = list.Count();
			var totalCalories = list.ElementAt(count - 1) + list.ElementAt(count - 2) + list.ElementAt(count - 3);
			Console.WriteLine($"sum of the three highest elf carries is: {totalCalories}");
		}
		public void Day1Part1()
		{
			var highest = 0;
			var oneElfsCalories = 0;
			foreach (var line in fileContent)
			{
				if (string.IsNullOrEmpty(line))
				{
					if (oneElfsCalories > highest)
						highest = oneElfsCalories;

					oneElfsCalories = 0;
				}
				else
				{
					var res = 0;
					var haveParsedToInt = Int32.TryParse(line, out res);
					if (!haveParsedToInt)
						throw new Exception($"cannot parse: {line} to int32");
					oneElfsCalories += res;
				}
			}

			Console.WriteLine($"highest elf carries: {highest}");
		}
	}
}
