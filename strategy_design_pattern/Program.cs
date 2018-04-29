using System;

namespace strategy_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int ip1, ip2 = 0;
            var add = new Add();
            var sub = new Subtract();
            var mul = new Multiple();
            var div = new Divide();

            IStrategyCtx sctx = new StrategyCtx();

            Console.WriteLine("Enter 2 numbers:");
            if (int.TryParse(Console.ReadLine(), out ip1))
            {
                if (int.TryParse(Console.ReadLine(), out ip2))
                {
                    Console.WriteLine("Addition : "+sctx.Perform(StrategyType.ADD, ip1, ip2));
                    Console.WriteLine("Subtraction : "+sctx.Perform(StrategyType.SUBTRACT, ip1, ip2));
                    Console.WriteLine("Multiplication : "+sctx.Perform(StrategyType.MULTIPLY, ip1, ip2));
                    Console.WriteLine("Division : " + sctx.Perform(StrategyType.DIVISION, ip1, ip2));
                }
                Console.ReadKey();
            }
        }
    }
}
