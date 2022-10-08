namespace Task2;

public class CarCatalog 
{
    private List<Car> Cars;

    public CarCatalog(params Car[] cars)
    {
        Cars = new List<Car>();
        foreach (var car in cars)
        {
            Cars.Add(car);
        }
        //Cars = new Car[cars.Length];
        //Cars = cars;
    }

    public void print_direct_order()
    {
        foreach (Car car in Cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    public void print_reverse_order()
    {
        foreach (Car car in Cars.Reverse<Car>())
        {
            Console.WriteLine(car.ToString());
        }
    }

    public void print_by_year()
    {
        Cars.Sort(new CarComparerYear());
        print_direct_order();
    }

    public void print_by_speed()
    {
        Cars.Sort(new CarComparerSpeed());
        print_direct_order();
    }

    public void print_by_name()
    {
        Cars.Sort(new CarComparerName());
        print_direct_order();
    }

    public void print_later_than(uint year)
    {
        var later_2003 = from Car in Cars
            where Car.ProductionYear >= year
            select Car;
        foreach (Car car in later_2003)
        {
            Console.WriteLine(car.ToString());
        }
    }
    
    public IEnumerator<Car> GetEnumerator()
    {
        foreach (var car in Cars)
        {
            yield return car;
        }
    }

    public IEnumerator<Car> Reverse()
    {
        for (int i = Cars.Count; i >= 0; ++i)
        {
            yield return Cars[i];
        }
    }

    public IEnumerator<Car> By_year()
    {
        Cars.Sort(new CarComparerYear());
        foreach (var car in Cars)
        {
            yield return car;
        }
    }

    public IEnumerable<Car> By_speed()
    {
        Cars.Sort(new CarComparerSpeed());
        foreach (var car in Cars)
        {
            yield return car;
        }
    }
}