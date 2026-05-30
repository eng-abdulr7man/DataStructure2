using System;

namespace Boxing_UnBoxing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//boxing 
			int val = 10;
			object obj = val;

			Console.WriteLine("val: " + val);
			Console.WriteLine("obj(boxing): " + obj);

			//unboxing
			int val2 = (int)obj;
			Console.WriteLine("val2(unboxing): " + val2);
		}
	}
}
