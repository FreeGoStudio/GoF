using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;
internal class OperationSub : Operation
{
	public override double Execute()
	{
		return Number1 - Number2;
	}
}
