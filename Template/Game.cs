using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template;
public abstract class Game
{

	/// <summary>
	/// 以下一系列方法不希望对外部开放，但需要被子类重写，因此定义成protected
	/// </summary>
	protected abstract void Initialize();
	protected abstract void StartPlay();
	protected abstract void EndPlay();

	/// <summary>
	/// 该方法用于给外部调用，因此定义成public
	/// </summary>
	public void Play()
	{
		Initialize();
		StartPlay();
		EndPlay();
	}
}
