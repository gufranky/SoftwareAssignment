namespace Assignment2_3_Eratosthenes_
{
    internal class Program
    {
        static List<int> Eratosthenes(int n=100)
        {
            int Now = 2;
            List<int> Prime = new List<int>();
            List<bool> IsPrime= new List<bool>();
            for (int i = 0; i <= n; i++)
            {
                IsPrime.Add(true);
            }
            while (Now <= n)
            {
                if (IsPrime[Now])
                {
                    Prime.Add(Now);
                    for (int i = Now * 2; i <= n; i += Now)
                    {
                        IsPrime[i] = false;
                    }
                }
                Now++;
            }
            return Prime;
        }
        static void Main(string[] args)
        {
            try 
            {
                int n= int.Parse(Console.ReadLine());
                List<int> Prime = Eratosthenes(n);
                foreach (int i in Prime)
                {
                    Console.Write(i + " ");
                }
            }
            catch
            {
                List<int> Prime = Eratosthenes();
                foreach (int i in Prime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}