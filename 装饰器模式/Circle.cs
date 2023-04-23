using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式;
internal class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("画一个圆!");
    }
}
