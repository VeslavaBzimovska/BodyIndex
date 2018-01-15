using System;

namespace BodyIndex

{
    class body
    {
        public static void Main(string[] args)
        {

			Console.WriteLine("Iveskite savo svori: ");
			float svoris = float.Parse(Console.ReadLine());

			Console.WriteLine("Iveskite savo ugi: ");

			float ugis = float.Parse(Console.ReadLine());

			Console.WriteLine(bmi(ugis, svoris));
			Console.ReadLine();


		}

		static string bmi(float ugis, float svoris)
		{
			float bmi = svoris / (ugis * ugis);

			if (bmi < 18.5)
			{
				return "Underweight";
			}
			else if (18.5 <= bmi && bmi < 25.0)
			{
				return "Normal weight";
			}
			else if (25.0 <= bmi && bmi < 30)
			{
				return "Overweight";
			}
			else
			{
				return "Obesity";
			}
		}
	}
}


        