using System;

namespace Step8
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				dynamic result = TESTModule(1);
				Console.WriteLine(result);  // 2
				result = TESTModule(2);
				Console.WriteLine(result);  // 4
				result = TESTModule(3);
				Console.WriteLine(result);  // 6
				result = TESTModule(4);
				Console.WriteLine(result);  // 8

				result = TESTModule(5);     // 15
				Console.WriteLine(result);

				result = TESTModule(1.0f);  // 3.0f
				Console.WriteLine(result);
				result = TESTModule(2.0f);  // 3.0f
				Console.WriteLine(result);
				result = TESTModule(5.0f);  // 5.0f (itself)
				Console.WriteLine(result);

				result = TESTModule("aaabb");   // "AAABB"
				Console.WriteLine(result);

				result = TESTModule(DateTime.Now);
				Console.WriteLine(result);

				result = TESTModule(0);     // throw exception
				Console.WriteLine(result);

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		static dynamic TESTModule(dynamic input)
		{
			Type type = input.GetType();

			switch (input)
			{
				case var _ when (type == typeof(int) && (input >= 1 && input <= 4)):
					return input * 2;
				case var _ when (type == typeof(int) && input > 4):
					return input * 3;
				case var _ when (type == typeof(int) && input < 1):
					throw new Exception("The entered value is an integer less than 1.");
				case var _ when (type == typeof(float) && (input == 1.0f || input == 2.0f)):
					return 3.0f;
				case var _ when (type == typeof(string)):
					return input.ToUpper();
				default:
					return input;
			}
		}
	}
}
