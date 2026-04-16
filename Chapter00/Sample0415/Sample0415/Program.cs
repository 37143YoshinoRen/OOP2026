using static System.Net.Mime.MediaTypeNames;

namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //入力
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            ////集計
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum = sum + array[i];
            //}
            //出力
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine();
                Console.Write("array[" + i + "]:" + array[i] + ":");
                astOut(array[i]);
            }
            //合計
            Console.WriteLine();
            Console.WriteLine("合計" + array.Where(n => n % 2 == 0).Sum());

        static void astOut(int num){
                //＊出力
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
