using System.Globalization;
using System.Runtime.InteropServices;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var y = Console.ReadLine();
            var x = Console.ReadLine();

            if (String.Compare(y, x,ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
