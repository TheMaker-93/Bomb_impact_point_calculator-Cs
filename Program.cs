using System;

namespace The_Impact_Point_Calculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// variables
			double plane_Altitude_Feets, plane_Altitude_Meters;
			double plane_Speed_MpH, plane_Speed_MpS;

			double impact_Time, impact_Distance;

			Console.WindowHeight = 17;			

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("**********************");
			Console.WriteLine("     IMPACT POINT     ");
			Console.WriteLine("**********************");
			Console.ResetColor();

			Console.WriteLine();

			Console.Write(" At what HEIGHT is the plane flying (feets) ? ");
			Console.ForegroundColor = ConsoleColor.Green;
			plane_Altitude_Feets = Convert.ToDouble(Console.ReadLine());
			Console.ResetColor();

			Console.Write(" At what SPEED is the plane flying (milles per hour) ? ");
			Console.ForegroundColor = ConsoleColor.Green;
			plane_Speed_MpH = Convert.ToDouble(Console.ReadLine());
			Console.ResetColor();

			// calculations I

			// feets to meters
			// 1 foot = 0.3048 meters
			plane_Altitude_Meters = plane_Altitude_Feets * 0.3048;
			// miles per hour to meters per second
			// 1 mph = 0.44704 mps
			plane_Speed_MpS = plane_Speed_MpH * 0.44704;

			// conversion 1
			Console.WriteLine();
			Console.WriteLine("A bomb droped from a bomber flying at");
			Console.Write("\t{0} feet", plane_Altitude_Feets);
			Console.Write(" (");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(" {0} ",Math.Round(plane_Altitude_Meters));
			Console.ResetColor();
			Console.WriteLine("meters ) ");

			// conversion 2
			Console.WriteLine(" and with a speed of ");
			Console.Write("\t{0} mph", plane_Speed_MpH);
			Console.Write(" (");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(" {0} ", Math.Round(plane_Speed_MpS));
			Console.ResetColor();
			Console.WriteLine("meters per second )");

			// calculations II

			// brace yourself dani
			// calculation of the seconds for impact
			impact_Time = Math.Sqrt(2 * plane_Altitude_Meters / 9.81);
			// impact point
			// d = v * t where d is distance on meters and v is meters per second
			impact_Distance = plane_Speed_MpS * impact_Time;

			// bomb part

			Console.WriteLine();
			Console.Write("It will take ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write( "{0}", Math.Round(impact_Time) );
			Console.ResetColor();
			Console.Write(" seconds to impact the ground \nand the impact point wil be");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(" {0} ", Math.Round(impact_Distance));
			Console.ResetColor();
			Console.WriteLine("meters away from it's lunch point ");

			Console.SetCursorPosition(0, Console.WindowHeight - 1);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Have a nice day, press any key to continue");
			Console.ReadKey();

		}
	}
}
