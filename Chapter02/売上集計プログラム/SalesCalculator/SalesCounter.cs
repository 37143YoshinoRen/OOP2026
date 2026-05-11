using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げ集計クラス
    public class SalesCounter {
        private readonly IEnumerable<Sale> sales;


        //コンストラクタ
        public SalesCounter(string filePath) {
            sales = ReadSales(filePath);
        }


        public IEnumerable<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();  //リスト
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');　//カンマ区切りで分割
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }
        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();

            foreach (var sale in sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }

    }
}
