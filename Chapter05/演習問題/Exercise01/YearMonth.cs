using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01{
    //5.1.1
    public class YearMonth{
        //プロパティ
        public int Year { get; init; }
        public int Month { get; init; }
        
        //コンストラクタ
        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        public bool Is21Century => 2001 <= Year && Year <= 2100;
         
        //5.1.3
        public YearMonth AddOneMonth {
            if(Month = 12 ){
            Month = 1
            }eles{
            Month++
            }

        
        //5.1.4
        public override string ToString() {
            return 
        }

    }
}
