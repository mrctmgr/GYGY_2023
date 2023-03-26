using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modified;

namespace Program
{
    public void Main(string[] args)
    {
        var modifiedCar = new ModifiedCar();
        modifiedCar.Name = "BMW";
        modifiedCar.ExaustType = new StandartExaust();
        modifiedCar.GearType = new ManuelGear();
        modifiedCar.TyresType = new StandartTyres();
        modifiedCar.DriverType = new StandartDriver();
        Console.WriteLine(modifiedCar.Name);
        Console.WriteLine(modifiedCar.ExaustType.GetExaustType(100));
        Console.WriteLine(modifiedCar.GearType.GetGearType(100));
        Console.WriteLine(modifiedCar.TyresType.GetTyresType(100));
        Console.WriteLine(modifiedCar.DriverType.GetDriverType(100));
    }
}