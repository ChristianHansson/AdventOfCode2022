using AdventOfCode2022.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day2
{
	public class Day2
	{
		private readonly List<string> fileContent;
		public Day2()
		{
			fileContent = FileLoader.ReadFile("2", "1");
			//fileContent = FileLoader.ReadDummyData("2", "1");
			//Day2_1();
			Day2_2();
		}

		private void Day2_2()
		{
			var totalScore = 0;
			foreach (var item in fileContent)
			{
				totalScore += new MakeRound(item).Score;
			}
			Console.WriteLine($"total score is: {totalScore}");
		}

		private void Day2_1()
		{
			var totalScore = 0;
			foreach(var item in fileContent)
			{
				totalScore += new MakeRound(item).Score;
			}
			Console.WriteLine($"total score is: {totalScore}");
		}
	}


	class MakeRound
	{
		public string MyAction { get; set; }
		public string TheirAction { get; set; }
		public string MatchResult { get; set; }
		public int Score { get; set; }
		private Dictionary<string, int> roundScores = new();
		private Dictionary<string, int> handPlayedScore = new();
		public MakeRound(string roundData)
		{
			roundScores.Add("win", 6);
			roundScores.Add("draw", 3);
			roundScores.Add("loss", 0);

			handPlayedScore.Add("X", 1);
			handPlayedScore.Add("Y", 2);
			handPlayedScore.Add("Z", 3);
			var a = roundData.Split(" ");
			TheirAction = a[0];

			//MyAction = a[1];

			MyAction = CalculateMyAction(a[1], TheirAction);

			MatchResult = Play();
			Score = handPlayedScore[MyAction] + roundScores[MatchResult];
		}
		private string CalculateMyAction(string winOrLoose, string opponentPlays)
		{
			if (winOrLoose == "X") // lose
			{
				if (opponentPlays == "A") return "Z";
				if (opponentPlays == "B") return "X";
				if (opponentPlays == "C") return "Y";
			}
			if (winOrLoose == "Y") // draw
			{
				if (opponentPlays == "A") return "X";
				if (opponentPlays == "B") return "Y";
				if (opponentPlays == "C") return "Z";
			}
			if (winOrLoose == "Z") // win
			{
				if (opponentPlays == "A") return "Y";
				if (opponentPlays == "B") return "Z";
				if (opponentPlays == "C") return "X";
			}
			return "";
		}
		/// <summary>
		/// A = Rock		X = Rock
		/// B = Paper		Y = Paper
		/// C = Sissors		Z = Sissors
		/// </summary>
		/// <returns></returns>
		public string Play()
		{
			if (TheirAction == "A")
			{
				if (MyAction == "Y")
					return "win";
				if (MyAction == "X")
					return "draw";
			}
			if (TheirAction == "B")
			{
				if (MyAction == "Z")
					return "win";
				if (MyAction == "Y")
					return "draw";
			}
			if (TheirAction == "C")
			{
				if (MyAction == "X")
					return "win";
				if (MyAction == "Z")
					return "draw";
			}
			return "loss";
		}
	}
}
