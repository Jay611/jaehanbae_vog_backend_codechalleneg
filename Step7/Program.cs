using System;
using System.Collections.Generic;

namespace Step7
{
	public static class QuestionClass
	{
		static List<string> NamesList = new List<string>()
		{
			"Jimmy",
			"Jeffrey",
			"John",
		};

		public static string GetNames => string.Join(Environment.NewLine, NamesList);
	}

	class Program
	{
		static void Main(string[] args)
		{
			var names = QuestionClass.GetNames;
			Console.WriteLine(names);
		}
	}
}
