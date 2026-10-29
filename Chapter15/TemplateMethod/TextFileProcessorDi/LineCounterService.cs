using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDi
{
    public class LineCounterService : ITextFileService {
        private int _count = 0;

        public void Initialize(string fname) =>
            _count = 0;
        
        public int Execute(string line) =>
            _count++;

        public void Terminate() =>
            Console.WriteLine("{0} 行", _count);
    }
}
