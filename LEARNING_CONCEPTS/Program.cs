using System;

namespace LEARNING_CSHARP
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeClass someClass = new SomeClass();
			SomeClass oSomeClass = new SomeClass(); // It's Better!
			SomeClass theSomeClass = new SomeClass();
			SomeClass objSomeClass = new SomeClass();

			oSomeClass.FirstName = "Dariush";
			//oSomeClass._lastName = "Tasdighi";

			Stack oStack = new Stack();

			SomeNewClass oSomeNewClass = new SomeNewClass();

			Queue oQueue = new Queue();

			oQueue.Push(5);
			oQueue.Push(11);
			oQueue.Push(7);

			int intResult;

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
