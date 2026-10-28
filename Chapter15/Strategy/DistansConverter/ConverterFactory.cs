using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public class ConverterFactory{
        private readonly static ConverterBase[] _converters = {
            new MeterConberter(),
            new FeetConberter(),
            new InchConberter(),
            new YardConberter(),
            new MileConberter(),
            new KiloConberter()
            };

        public static ConverterBase? GetInstance(string name) =>
            _converters.FirstOrDefault(x =>x.IsMyUnit(name));  
    }
}
