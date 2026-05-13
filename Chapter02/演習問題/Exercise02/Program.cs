using static Exercise02.lnchConverter;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintInchToMeterList(1, 10);
            
        }

        //インチからメートルへの対応表を出力
            static void PrintInchToMeterList(int start, int stop) {
                for (int feet = start; feet <= stop; feet++) {
                    double meter = InchConverter.ToMeter(feet);
                    Console.WriteLine($"{feet}ft = {meter:00.0000}m");
                }
            }


        }
    }
