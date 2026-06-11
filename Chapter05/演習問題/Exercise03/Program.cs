using Exercise01;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {

            var ym1 = new YearMonth(2000, 1);
            var ym2 = new YearMonth(2030, 4);
            if (ym1 == ym2)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");
        }
    }
}


