namespace Section01 {
    internal class Program {

        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };
            //文字数が6文字以上・oを含む・最後がn
            var exists = cities.Exists(s => 6 <= s.Length && s.Contains('o') && s.EndsWith('n'));
            Console.WriteLine(exists);
            
            
            
            }
        }
    }
