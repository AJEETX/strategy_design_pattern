namespace strategy_design_pattern
{
    enum StrategyType { ADD,SUBTRACT,MULTIPLY,DIVISION}
    public interface IStrategy
    {
        int Calculate(int x,int y);
    }
    class Add : IStrategy
    {
        public int Calculate(int x, int y) { return x+y ; }
    }
    class Subtract : IStrategy
    {
        public int Calculate(int x, int y) { return x - y; }
    }
    class Multiple : IStrategy
    {
        public int Calculate(int x, int y) { return x * y; }
    }
    class Divide : IStrategy
    {
        public int Calculate(int x, int y) { return x / y; }
    }
}
