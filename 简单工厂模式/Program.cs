namespace SimpleFactory;

internal class Program
{
	static void Main(string[] args)
	{
		Operation operation;
		operation = OperationFactory.CreateOperate("+");
		operation.Number1 = 1;
		operation.Number2 = 2;
		double result = operation.Execute();
		Console.WriteLine(result);
		Console.ReadLine();
	}
}
