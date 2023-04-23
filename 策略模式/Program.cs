namespace 策略模式;

internal class Program
{
	static void Main(string[] args)
	{
		double number1 = 1d;
		double number2 = 2d;

		Context context = null;
		context = new Context(new OperationAdd());
		double result1 = context.Execute(number1, number2);

		Console.WriteLine(result1);

		context = new Context(new OperationSub());
		context.Execute(number1, number2);
		double result2 = context.Execute(number1, number2);

		Console.WriteLine(result2);

		Console.ReadKey();
	}
}
