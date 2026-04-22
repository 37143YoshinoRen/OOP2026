double feet = 0;


if(args.Length >= 3
              &&int.TryParse(args[1], out int start)
                && int.TryParse(args[2], out int end))
{


    if (args[0] == "-tom")
    {
        PrintMeterToFeetList(start, end); //メートルへ変換
    }
    else if (args[0] == "-tof")
    {
        PrintFeetToMeterList(start, end); //フィートへ変換
    }
    else
    {
        Console.WriteLine("引数エラー");
    }
}
else
{
    Console.WriteLine("エラー");
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
