using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式;
/// <summary>
/// 上下文
/// </summary>
internal class Context
{
	Operation _strategy;

	public Context(Operation strategy)
	{
		this._strategy = strategy;
	}

	public double Execute(double number1, double number2)
	{
		return _strategy.Execute(number1, number2);
	}
}
