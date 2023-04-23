using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;
class OperationAdd : Operation
{
	public override double Execute()
	{
		return Number1 + Number2;
	}
}
