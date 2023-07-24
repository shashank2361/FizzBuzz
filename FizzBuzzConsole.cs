
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
            for (int i = 0; i <= 100; i++)
            {
                object[] mParam = new object[] { i };              
                string result = (string)typeFitbuzz.InvokeMember("GetFizzBuzz", BindingFlags.InvokeMethod, null, obj, mParam);
                Console.WriteLine(string.Format(" number {0} : Result {1}", i.ToString(), result));
            }

            // string result = FizzBuzzService.GetFizzBuzz(i);
               Console.WriteLine("//================Finish=========================================");



        }

    }
}
