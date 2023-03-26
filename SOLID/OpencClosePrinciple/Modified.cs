using System;


public interface IExaustType
{
    public double GetExaustType(double totalSpeed);
}

public interface IGearType
{
    public double GetGearType(double totalSpeed);
}

public interface ITyresType
{
    public double GetTyresType(double totalSpeed);
}

public interface IDriverType
{
    public double GetDriverType(double totalSpeed);
}

public class ModifiedCar
{
    public string Name { get; set; }
    public IExaustType ExaustType { get; set; }
    public IGearType GearType { get; set; }
    public ITyresType TyresType { get; set; }
    public IDriverType DriverType { get; set; }

}

public class StandartExaust : IExaustType
{
    public double GetExaustType(double totalSpeed)
    {
        return totalSpeed * 1.2;
    }
}

public class E46Exaust : IExaustType
{
    public double GetExaustType(double totalSpeed)
    {
        return totalSpeed * 1.4;
    }
}

public class Z3Exaust : IExaustType
{
    public double GetExaustType(double totalSpeed)
    {
        return totalSpeed * 1.6;
    }
}

public class ManuelGear : IGearType
{
    public double GetGearType(double totalSpeed)
    {
        return totalSpeed * 1.2;
    }
}

public class SemiAutomaticGear : IGearType
{
    public double GetGearType(double totalSpeed)
    {
        return totalSpeed * 1.4;
    }
}

public class AutomaticGear : IGearType
{
    public double GetGearType(double totalSpeed)
    {
        return totalSpeed * 1.6;
    }
}

public class MichelinTyres : ITyresType
{
    public double GetTyresType(double totalSpeed)
    {
        return totalSpeed * 1.2;
    }
}

public class PirelliTyres : ITyresType
{
    public double GetTyresType(double totalSpeed)
    {
        return totalSpeed * 1.4;
    }
}

public class BridgestoneTyres : ITyresType
{
    public double GetTyresType(double totalSpeed)
    {
        return totalSpeed * 1.6;
    }
}

public class NewDriver : IDriverType
{
    public double GetDriverType(double totalSpeed)
    {
        return totalSpeed * 1.2;
    }
}

public class AmateurDriver : IDriverType
{
    public double GetDriverType(double totalSpeed)
    {
        return totalSpeed * 1.4;
    }
}

public class ProfessionalDriver : IDriverType
{
    public double GetDriverType(double totalSpeed)
    {
        return totalSpeed * 1.6;
    }
}

public ModifiedCar CreateModifiedCar(string name, IExaustType exaustType, IGearType gearType, ITyresType tyresType, IDriverType driverType)
{
    return new ModifiedCar
    {
        Name = name,
        ExaustType = exaustType,
        GearType = gearType,
        TyresType = tyresType,
        DriverType = driverType
    };
}

