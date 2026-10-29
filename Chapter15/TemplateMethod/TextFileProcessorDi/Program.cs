using TextFileProcessorDi;

var seevice = new LineCounterService();
var processor = new TextFileProcessor(seevice);
string fileName = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section03\Section03.csproj";
    processor.Run(fileName);



