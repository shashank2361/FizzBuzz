
using FizzBuzz.Service;
 
using System.Reflection;

namespace FizzBuzz
{
    public  class FizzBuzzConsole
    {
        public void Run()
        {
            Console.WriteLine("=============Fizz Buzz Start=============");
            Type typeFitbuzz = typeof(FizzBuzzService);
            object obj = Activator.CreateInstance(typeFitbuzz);
            for (int i = 1; i <= 100; i++)
            {
                object[] mParam = new object[] { i };              
                string result = (string)typeFitbuzz.InvokeMember("GetFizzBuzz", BindingFlags.InvokeMethod, null, obj, mParam);
                Console.WriteLine(string.Format(" number {0} : Result {1}", i.ToString(), result));
            }
            Console.WriteLine("//================Finish=========================================");
        }
    }
}
