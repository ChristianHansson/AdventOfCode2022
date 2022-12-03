
using AdventOfCode2022.Helpers;

namespace AdventOfCode2022.Day3
{
	public class Day3
	{
		private readonly List<string> fileContent;
		private string ScoreChars = "_abcdefghijklmnopqrstuvWxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
		public Day3()
		{
			//fileContent = FileLoader.ReadFileWithoutPart("3");
			fileContent = FileLoader.ReadDummyDataWithoutPart("3");
			Part1();
		}
		private void Part1()
		{
			var listOfSharedLetters = new List<char>();
			foreach (var item in fileContent)
			{
				var len = item.Length;
				var firstCompartment = item.Substring(0, (int)(len / 2));
				var secondCompartment = item.Substring((int)(len / 2));
				
				for(var i = 0; i < firstCompartment.Length; i++)
				{
					var letter = firstCompartment[i];

					if (secondCompartment.Contains(letter))
					{
						listOfSharedLetters.Add(letter);
						break;
					}
				}
			}
			var score = 0;
			foreach (var item in listOfSharedLetters)
			{
				Console.WriteLine($"letter: {item} -> gives score: {ScoreChars.IndexOf(item)}");
				score += ScoreChars.IndexOf(item);
			}
			Console.WriteLine($"score is: {score}");
		}
	}
}
