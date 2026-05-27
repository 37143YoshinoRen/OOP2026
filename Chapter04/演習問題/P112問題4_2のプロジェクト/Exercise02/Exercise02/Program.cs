
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        private static void Exercise1() {
            //if-else文を使用(コード4.9)
            var line = Console.ReadLine();
            int num = int.Parse(line);
            if(0 > num) {
                Console.WriteLine(num);
            }else if(100 > num && num >= 0) {
                Console.WriteLine(num * 2);

                }else if(100 <=num && 500 > num) {
                Console.WriteLine(num * 3);
            }else if(500 >= num) {
                Console.WriteLine(num);
            }
        }
        

        private static void Exercise2() {
            //switch文を使用(コード4.10)

        }

        private static void Exercise3() {
            //switch式を使用(コード4.11)


        }
    }
}
