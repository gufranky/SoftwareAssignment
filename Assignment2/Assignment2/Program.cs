using System.Numerics;

namespace Assignment2
{
    internal class Program
    {
        public static List<int> GetFactor(int n)
        {
            List<int> factors = new List<int>();
            int i = 2;
            while(n!=1)
            {
                if(n%i==0)
                {
                    factors.Add(i);
                    n /= i;
                }
                else
                {
                    i++;
                }
            }
            return factors;
        }
        static void Main(string[] args)
        {
            int a;
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("请输入整数"); return; 
            }
            List<int> factors = GetFactor(a);
            for(int i=0;i<factors.Count;i++)
            {
                if(i==factors.Count-1)
                {
                    Console.Write(factors[i]);
                }
                else
                {
                    Console.Write(factors[i] + "*");
                }
            }
        }
    }
}