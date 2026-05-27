
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
        "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {

            Console.WriteLine("\nforach文で出力");
            foreach (var s in langs) {
                if(s.Contains('S'))
                Console.WriteLine(s);
                  }
            
            Console.WriteLine("\nfor文で出力");
            for(int i = 0; i<langs.Count; i++) {
                if (langs[i].Contains('S'))
                    Console.WriteLine(langs[i]);
            }

            Console.WriteLine("\nWhile");
            int count = 0;
            while (count < langs.Count) {
                if (langs[count].Contains('S'))
                    Console.WriteLine(langs[count]);
                count++;
            }
        }
       
        private static void Exercise2(List<string> langs) {
            Console.WriteLine("\n ---4.1.2---");
            //LINQを使用する(Where)
            var selected = langs.Where(s => s.Contains('S'));
                Console.WriteLine(selected);
        }

        private static void Exercise3(List<string> langs) {
            Console.WriteLine("\n---4.1.3---");
            Console.WriteLine(langs.Find(s => s.Length == 10) ?? "unknown");
            Console.WriteLine(langs);
            }
        }
    }
