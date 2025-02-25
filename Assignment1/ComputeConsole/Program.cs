namespace ConsoleCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个整数和一个运算符，用空格隔开");
            string inputs = Console.ReadLine();
            string[] input = inputs.Split(' ');
            int first = int.Parse(input[0]);
            int second = int.Parse(input[1]);
            switch (input[2])
            {
                case "+":
                    Console.WriteLine(first + second);
                    break;
                case "-":
                    Console.WriteLine(first - second);
                    break;
                case "*":
                    Console.WriteLine(first * second);
                    break;
                case "/":
                    if (second == 0)
                    {
                        Console.WriteLine("除数不能为0");
                        break;
                    }
                    Console.WriteLine(first / second);
                    break;
                default:
                    Console.WriteLine("输入错误");
                    break;
            }

        }
    }
}