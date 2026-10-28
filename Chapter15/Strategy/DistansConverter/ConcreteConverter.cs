using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter;

public class  MeterConberter : ConverterBase {
    public override bool IsMyUnit(string name) => 
        name.Equals("yard", StringComparison.CurrentCultureIgnoreCase) || name == UnitName;
    protected override double Ratio => 1;
    public override string UnitName => "メートル";
}
public class FeetConberter : ConverterBase {
    public override bool IsMyUnit(string name) => 
        name.Equals("yard", StringComparison.CurrentCultureIgnoreCase) || name == UnitName;
    protected override double Ratio => 0.3048;
    public override string UnitName => "フィート";
}
public class InchConberter : ConverterBase {
    public override bool IsMyUnit(string name) => 
        name.Equals("yard", StringComparison.CurrentCultureIgnoreCase) || name == UnitName;
    protected override double Ratio => 0.0254;
    public override string UnitName => "インチ";
}
public class YardConberter : ConverterBase {
    public override bool IsMyUnit(string name) => 
        name.Equals("yard", StringComparison.CurrentCultureIgnoreCase) || name == UnitName;
    protected override double Ratio => 0.9144;
    public override string UnitName => "ヤード";
}
public class MileConberter : ConverterBase {
    public override bool IsMyUnit(string name) =>
        name.Equals("yard", StringComparison.CurrentCultureIgnoreCase) || name == UnitName;
    protected override double Ratio => 1.609;
    public override string UnitName => "マイル";
}
public class KiloConberter : ConverterBase {
    public override bool IsMyUnit(string name) => 
        name.Equals("yard", StringComparison.CurrentCultureIgnoreCase) || name == UnitName;
    protected override double Ratio => 0.001;
    public override string UnitName => "キロ";
}

