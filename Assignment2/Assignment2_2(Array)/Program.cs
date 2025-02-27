namespace Assignment2_2_Array_
{
    internal class Program
    {
        static int[]getArray(string s)
        {
            string[] StringInt = s.Split(' ');
            int[] IntArray = new int[StringInt.Length];
            int i = 0;
            foreach (string str in StringInt)
            {
                IntArray[i] = int.Parse(str);
                i++;
            }
            return IntArray;
        }   
        static void ArrayCal(int[] array,out int max,out int min,out double ave,out double sum)
        {
            max = min = array[0]; sum = 0;
            foreach(int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                sum += num;
            } 
            ave = sum / array.Length;
            return;
        }   
        static void Main(string[] args)
        {
            string Input;
            Input=Console.ReadLine();
            int[] IntArray = getArray(Input); 
            ArrayCal(IntArray, out int max, out int min, out double ave, out double sum);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Ave: " + ave);
            Console.WriteLine("Sum: " + sum);
        }
    }
}