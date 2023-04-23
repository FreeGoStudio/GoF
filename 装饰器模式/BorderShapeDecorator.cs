using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式;
internal class BorderShapeDecorator : ShapeDecorator
{
    public BorderShapeDecorator(IShape decorated) : base(decorated)
    {
    }

    public override void Draw()
    {
        base.Draw();
        DrawBorder();
    }

    void DrawBorder()
    {
        Console.WriteLine("描边框");
    }
}
