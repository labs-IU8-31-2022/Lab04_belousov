// See https://aka.ms/new-console-template for more information

using Lab04_belousov;

class Program
{
    static void Main(string[] args)
    {
        MyMatrix m1 = new MyMatrix(2, 2, 4);
        MyMatrix m2 = new MyMatrix(2, 2, 4);
        Console.WriteLine("Matrix 1 is: ");
        m1.print_the_matrix();
        Console.WriteLine("Matrix 2 is: ");
        m2.print_the_matrix();
        MyMatrix new_matrix = m1 + m2;
        Console.WriteLine("New matrix: ");
        new_matrix.print_the_matrix();
    }
}
