using FizzBuzz.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public  class FizzBuzzConsole
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzConsole(IFizzBuzzService  fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        public void Run()
        {
            Console.WriteLine("=============Fizz Buzz Start=============");
            for (int i = 0; i <= 100; i++)
            {
                string result = _fizzBuzzService.GetFizzBuzz(i);
                Console.WriteLine( string.Format(" number {0} : Result {1}" ,   i.ToString() ,  result));
            }
            Console.WriteLine("//================Finish=========================================");



        }

    }
}
