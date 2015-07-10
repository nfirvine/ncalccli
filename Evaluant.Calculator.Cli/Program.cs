using System;

namespace NCalc.Cli
{
	public class Program
	{
        public static int Usage() {
            Console.WriteLine("Usage: NCalcCli <-p|-e> <expression>");
            return 1;
        }

		public static int Main(string[] args)
		{
            string unparsed;
            try {
                unparsed = args[1];
            } catch (IndexOutOfRangeException e) {
                return Usage();
            }
            switch (args[0]) {
                case "-p":
                    Console.Write("Parsing '{0}'...", unparsed);
                    try {
                        Expression.Compile(unparsed, false);
                    } catch (EvaluationException e) {
                        Console.WriteLine("Failed: {0}", e);
                        return 2;
                    }
                    Console.WriteLine("Success!");
                    return 0;
                case "-e":
                    Console.WriteLine(new Expression(unparsed).Evaluate());
                    return 0;
                default:
                    return Usage();
            }
        }
	}
}
