namespace N5__YP__Task_4_04._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива m: ");
            int m = int.Parse(Console.ReadLine());
            int[] D = new int[m];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < m; i++) D[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) if (D[i] < 0) D[i] = 0;

            Console.WriteLine("Массив после замены отрицательных элементов нулями:");
            Console.WriteLine(string.Join(" ", D));
        }
    }
}
