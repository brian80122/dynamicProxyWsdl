using System;

namespace DynamicProxy
{
    internal class Program
    {
        //reference https://learn.microsoft.com/en-us/archive/msdn-technet-forums/39138d08-aa08-4c0c-9a58-0eb81a672f54
        static void Main(string[] args)
        {
            var parameter = new object[2] { 10, 20 };
            var result = WsProxy.CallWebServiceWtihUrl("http://www.dneonline.com/calculator.asmx", "Calculator", "Add", parameter);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
