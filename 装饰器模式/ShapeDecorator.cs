using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰器模式;
internal abstract class ShapeDecorator : IShape
{
    IShape _decorated;

    public ShapeDecorator(IShape decorated)
    {
        _decorated = decorated;
    }

    public virtual void Draw()
    {
        _decorated.Draw();
    }
}
