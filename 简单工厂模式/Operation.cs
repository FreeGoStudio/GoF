using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;
public abstract class Operation
{
	private double _number1 = 0;
	private double _number2 = 0;

	public double Number1 { get => _number1; set => _number1 = value; }
	public double Number2 { get => _number2; set => _number2 = value; }

	public abstract double Execute();
}
