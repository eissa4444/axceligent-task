using System;
using System.Threading.Tasks;

namespace MethodSignature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        async Task<(double averageSalary,long numberOfEmployee)> SomeCalculation(long param1, int param2, bool param3)
        {
            return await Task.FromResult((5550,1259885));
        }
    }
}
