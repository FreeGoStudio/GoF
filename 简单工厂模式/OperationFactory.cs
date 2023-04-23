using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;
public class OperationFactory
{
	public static Operation CreateOperate(string operate)
	{
		Operation operation = null;
		switch(operate)
		{
			case "+":
				operation = new OperationAdd();
				break;
			case "-":
				operation = new OperationSub();
				break;
		}
		return operation;
	}
}
