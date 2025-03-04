namespace Assignment2_4
{
    internal class Program
    {
        static bool checkMatrix(int[,] matrix, int m, int n)
        {
            int min = m < n ? m : n;
            int ans = matrix[0, 0];
            for (int i = 1; i < min; i++)
            {
                if (matrix[i, i] != ans)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int m, n;
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            m = int.Parse(inputs[0]);
            n = int.Parse(inputs[1]);
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string row = Console.ReadLine();
                string[] rows = row.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(rows[j]);
                }
            }
            bool ans =checkMatrix(matrix, m, n);
            if (ans)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //定义一个m * n的二维数组
        }
    }
}