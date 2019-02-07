# strategy design pattern ![GitHub release](https://img.shields.io/github/release/ajeetx/strategy_design_pattern.svg?style=for-the-badge) ![Maintenance](https://img.shields.io/maintenance/yes/2019.svg?style=for-the-badge)

![Travis](https://img.shields.io/travis/AJEETX/strategy_design_pattern.svg) |![GitHub Release Date](https://img.shields.io/github/release-date/ajeetx/strategy_design_pattern.svg)| [![.Net Framework](https://img.shields.io/badge/DotNet-2.0-blue.svg?style=plastic)](https://www.microsoft.com/en-au/download/details.aspx?id=1639) | ![GitHub language count](https://img.shields.io/github/languages/count/ajeetx/strategy_design_pattern.svg) | ![GitHub top language](https://img.shields.io/github/languages/top/ajeetx/strategy_design_pattern.svg) |![GitHub repo size in bytes](https://img.shields.io/github/repo-size/ajeetx/strategy_design_pattern.svg) 
| ---          | ---        | ---      | ---        |  --- | --- |

---------------------------------------
## Introduction

A very simple strategy design pattern implementation.   

## Repository codebase
 
The repository consists of a project:
1) Asp.Net Core2 Console 

## Features
The calculation on 2 numbers can be made through different ways/strategy(s).
Basic strategy is defined in an interface 
```
    public interface IStrategy
    {
        int Calculate(int x,int y);
    }
```
- Addition calculation implementation 
```
    class Add : IStrategy
    {
        public int Calculate(int x, int y) { return x+y ; }
    }
```
- Subtraction calculation implementation 
```
    class Subtract : IStrategy
    {
        public int Calculate(int x, int y) { return x-y ; }
    }
```
- Multiplication calculation implementation 
```
    class Multiple : IStrategy
    {
        public int Calculate(int x, int y) { return x*y ; }
    }
```
- Division calculation implementation 
```
    class Divide : IStrategy
    {
        public int Calculate(int x, int y) { return x/y ; }
    }
```
- Strategy implementation 
```
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
```
### Support or Contact

Having any trouble? Check out our [documentation](https://github.com/AJEETX/strategy_design_pattern/blob/master/README.md) or [contact support](mailto:ajeetkumar@email.com) and we’ll help you sort it out.


[![HitCount](http://hits.dwyl.io/ajeetx/strategy_design_pattern/projects/1.svg)](http://hits.dwyl.io/ajeetx/strategy_design_pattern/projects/1) | ![GitHub contributors](https://img.shields.io/github/contributors/ajeetx/strategy_design_pattern.svg?style=plastic)|![license](https://img.shields.io/github/license/ajeetx/strategy_design_pattern.svg?style=plastic)|
 | --- | --- | ---|
