using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template;
public class Football : Game
{
	protected override void Initialize()
	{
		Console.WriteLine("Initialize Football Game!");
	}

	protected override void StartPlay()
	{
		Console.WriteLine("Start Football Game!");
	}

	protected override void EndPlay()
	{
		Console.WriteLine("End Football Game!");
	}

}
