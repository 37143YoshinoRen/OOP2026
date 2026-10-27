using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter;

public class  MeterConberter : ConverterBase {
    public override bool IsMyUnit(string name) => name.ToLower() == "meter" || name == UnitName;
    protected override double Ratio => 1;
    public override string UnitName => "メートル";
}
public class FeetConberter : ConverterBase {
    public override bool IsMyUnit(string name) => name.ToLower() == "meter" || name == UnitName;
    protected override double Ratio => 0.3048;
    public override string UnitName => "フィート";
}
public class InchConberter : ConverterBase {
    public override bool IsMyUnit(string name) => name.ToLower() == "meter" || name == UnitName;
    protected override double Ratio => 0.0254;
    public override string UnitName => "インチ";
}
public class YardConberter : ConverterBase {
    public override bool IsMyUnit(string name) => name.ToLower() == "meter" || name == UnitName;
    protected override double Ratio => 0.9144;
    public override string UnitName => "ヤード";
}

