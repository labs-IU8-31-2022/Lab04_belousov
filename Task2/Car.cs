using Microsoft.VisualBasic.CompilerServices;

namespace Task2;
using System;
using System.Linq;
using System.Collections;
using System.Xml.Linq;
public class Car
{
    public string Name { get; set; }
    public uint ProductionYear { get; set; }
    public uint MaxSpeed { get; set; }
    public Car(string name, uint year, uint speed) => (Name, ProductionYear, MaxSpeed) = (name, year, speed);
    
    public override string ToString()
    {
        return $"{Name} {ProductionYear} {MaxSpeed}";
    }
}

class CarComparerSpeed : IComparer<Car>
{
    public int Compare(Car car1, Car car2)
    {
        return (car1.MaxSpeed > car2.MaxSpeed) ? 1 : -1;
    }
}

class CarComparerYear : IComparer<Car>
{
    public int Compare(Car car1, Car car2)
    {
        return (car1.ProductionYear > car2.ProductionYear) ? 1 : -1;
    }
}

class CarComparerName : IComparer<Car>
{
    public int Compare(Car car1, Car car2)
    {
        return string.Compare(car1.Name, car2.Name);
    }
}