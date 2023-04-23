using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式;
/// <summary>
/// 具体算法A
/// </summary>
internal class OperationAdd : Operation
{
	public override double Execute(double number1, double number2)
	{
		return number1 + number2;
	}
}
