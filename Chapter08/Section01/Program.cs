namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();



        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");


            while (true) {
                //1,都道府県を入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) break; //無限ループを抜ける(Ctrl + 'Z')

                //2,県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();
                if (prefCaptalLocation == null) break; //無限ループを抜ける(Ctrl + 'Z')
                //3,県庁所在地登録処理
                prefOfficeDict.Add(pref, prefCaptalLocation);
                
            }

            while (true) {
                Console.WriteLine("***メニュー***");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");

                var i = Console.ReadLine();
                if (int.TryParse(i, out var h)) {
                    if (h == 1) {
                        foreach (var item in prefOfficeDict) {
                            Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です。");
                        }
                    } else if (h == 2) {
                        Console.Write("都道府県:");
                        var K = Console.ReadLine();
                        var prefO = prefOfficeDict[K];
                        Console.WriteLine($"{K}の県庁所在地は{prefO}です。");
                    } else if (h == 9) {
                        break;
                    }
                }
            }
        }
    }
}
