using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式;
internal class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape decorated) : base(decorated)
    {
    }

    public override void Draw()
    {
        base.Draw();
        FillRed();
    }

    void FillRed()
    {
        Console.WriteLine("红色的");
    }
}
