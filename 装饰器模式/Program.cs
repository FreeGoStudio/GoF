namespace 装饰器模式;

internal class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();

        RedShapeDecorator redShapeDecorator = new RedShapeDecorator(circle);

        Rectangular rectangular = new Rectangular();

        RedShapeDecorator redShapeDecorator1 = new RedShapeDecorator(rectangular);
        BorderShapeDecorator borderShapeDecorator = new BorderShapeDecorator(redShapeDecorator1);

        redShapeDecorator.Draw();

        borderShapeDecorator.Draw();

        Console.ReadLine();
    }
}
