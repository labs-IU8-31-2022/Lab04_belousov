// See https://aka.ms/new-console-template for more information

using Task2;

class Program
{
    static void Main(string[] args)
    {
        void print_the_list(List<Car> list)
        {
            foreach (var elem in list)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        // Task2
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Bmw", 1999, 200));
            cars.Add(new Car("Audi", 2000, 220));
            cars.Add(new Car("Volvo", 2005, 210));
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine("How do you want to sort \n 1 - by Name \n 2 - by year \n 3 - by speed \n");
            int sorting = Convert.ToInt16(Console.ReadLine());
            switch (sorting)
            {
                case 1:
                {
                    cars.Sort(new CarComparerName());
                    print_the_list(cars);
                    break;
                }
                case 2:
                {
                    cars.Sort(new CarComparerYear());
                    print_the_list(cars);
                    break;
                }
                case 3:
                {
                    cars.Sort(new CarComparerSpeed());
                    print_the_list(cars);
                    break;
                }
                default:
                {
                    throw new Exception("Unacceptable flag");
                }
            }
            
        }
        
        
        //Task3
        {
            //Car c1 = new Car("Bmw", 2003, 200);
            Car c2 = new Car("Audi", 2000, 210);
            Car c1 = new Car("Bmw", 2003, 200);
            Car c3 = new Car("Volvo", 2005, 220);
            Car c4 = new Car("Vaz", 1995, 170);
            CarCatalog catalog = new CarCatalog(c1, c2, c3, c4);
            Console.WriteLine("Before sorting: ");
            catalog.print_direct_order();
            Console.WriteLine("=====================\nAfter sorting: ");
            //catalog.print_by_name();
            foreach (var car in catalog.By_speed())
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}