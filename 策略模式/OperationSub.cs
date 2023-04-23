using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式;
/// <summary>
/// 算法B实现
/// </summary>
internal class OperationSub : Operation
{
	public override double Execute(double number1, double number2)
	{
		return number1 - number2;
	}
}
