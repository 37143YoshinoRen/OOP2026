using Exercise03;

var seevice = new Take20Processor();
var processor = new ITextFileProcessor(seevice);
Console.WriteLine();
processor.Run(fileName);



