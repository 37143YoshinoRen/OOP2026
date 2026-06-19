namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            var books = Books.GetBooks();
            var priceAverage = books.Average(x => x.Price);
            var pageAverage = books.Sum(x => x.Pages);
            var maxPrice = books.Max(x => x.Price);

            Console.WriteLine("平均金額：" + priceAverage);
            Console.WriteLine("合計ページ:" + pageAverage);
            Console.WriteLine("高価な本" + maxPrice);

            Console.WriteLine("---500円以上の本---");

            foreach (var a in books.Where(s => s.Price >= 500)) {
                Console.WriteLine(a.Title);
            }

            //250ページ以上の本の上位3冊出力
            var boook = books.Where(s => s.Pages >= 250).Take(3);
                foreach(var i in boook)
                Console.WriteLine(i.Title);
            }
        }
    }
