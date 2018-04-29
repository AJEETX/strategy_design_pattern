using System.Collections.Generic;

namespace strategy_design_pattern
{
    interface IStrategyCtx
    {
        int Perform(StrategyType type, int x, int y);
    }
    class StrategyCtx : IStrategyCtx
    {
        Dictionary<StrategyType, IStrategy> d = new Dictionary<StrategyType, IStrategy>();
        public StrategyCtx()
        {
            d.Add(StrategyType.ADD, new Add());
            d.Add(StrategyType.SUBTRACT, new Subtract());
            d.Add(StrategyType.MULTIPLY, new Multiple());
            d.Add(StrategyType.DIVISION, new Divide());
        }
        public int Perform(StrategyType type, int x, int y)
        {
            return d[type].Calculate(x, y);
        }
    }
}
