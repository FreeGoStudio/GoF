using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template;
public class Cricket : Game
{
	protected override void Initialize()
	{
		Console.WriteLine("Initialize Cricket!");
	}

	protected override void StartPlay()
	{
		Console.WriteLine("StartPlay Cricket!");
	}

	protected override void EndPlay()
	{
		Console.WriteLine("EndPlay Cricket!");
	}
}
