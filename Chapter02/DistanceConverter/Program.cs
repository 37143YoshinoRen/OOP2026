double feet = 0;

if (args.Length < 1 || args[0] == "-tom")
{
    PrintMeterToFeetList(10, 30); //メートルへ変換
}
else if (args.Length < 1 || args[0] == "-tof")
{
    PrintFeetToMeterList(5, 15); //フィートへ変換
}
else
{
    Console.WriteLine("引数エラー");
}

void PrintMeterToFeetList(int start, int end)
{
    //フィートからメートルへの対応表を出力
    for (int meter = start; meter <= end; meter++)
    {
        double feet = MeterToFeet(meter);
        Console.WriteLine($"{meter}m = {feet:0.0000}ft");
    }
}
void PrintFeetToMeterList(int start, int end)
{
    //フィートからメートルへの対応表を出力
    for (int feet = start; feet <= end; feet++)
    {
        double meter = FeetToMeter(feet);
        Console.WriteLine($"{feet}ft = {meter:0.0000}m");
    }
}
//フィートからメートルを求める
double FeetToMeter(int fett)
{
    //feet * 0.3048
    return feet * 0.3048;
}
//メートルからフィートを求める
double MeterToFeet(int meter)
{
    return meter / 0.3048;
}
