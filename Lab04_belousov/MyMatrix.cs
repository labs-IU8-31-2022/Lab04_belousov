namespace Lab04_belousov;

public class MyMatrix
{
    private static int _Colomns, _Rows;
    private int Range_of_numbers;
    public int Colomns { get => _Colomns; }
    public int Rows { get => _Rows; }

    public int[,] Matrix;
    public MyMatrix(int _n, int _m, int range)
    {
        Random random_number = new Random();
        _Rows = _n;
        _Colomns = _m;
        Range_of_numbers = range;
        Matrix = new int[_Rows, _Colomns];
        for (uint i = 0; i < _Rows; ++i)
        {
            for (uint j = 0; j < _Colomns; ++j)
            {
                Matrix[i, j] = random_number.Next() % Range_of_numbers;
            }
        }
    }
    
    public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
    {
        if (matrix1.Colomns != matrix2.Colomns || matrix2.Colomns != matrix2.Rows)
        {
            throw new Exception("Matrices have different sizes");
        }
        for (int i = 0; i < matrix1.Rows; ++i)
        {
            for (int j = 0; j < matrix1.Colomns; ++j)
            {
                matrix1.Matrix[i, j] += matrix2.Matrix[i, j];
            }
        }
        return matrix1;
    }
    
    public static MyMatrix operator -(MyMatrix matrix1, MyMatrix matrix2)
    {
        if (matrix1.Colomns != matrix2.Colomns || matrix2.Colomns != matrix2.Rows)
        {
            throw new Exception("Matrices have different sizes");
        }
        for (int i = 0; i < matrix1.Rows; ++i)
        {
            for (int j = 0; j < matrix1.Colomns; ++j)
            {
                matrix1.Matrix[i, j] -= matrix2.Matrix[i, j];
            }
        }
        return matrix1;
    }

    public static MyMatrix operator *(MyMatrix matrix, int number)
    {
        for (int i = 0; i < matrix.Rows; ++i)
        {
            for (int j = 0; j < matrix.Colomns; ++j)
            {
                matrix[i, j] *= number;
            }
        }
        return matrix;
    }
    
    public void print_the_matrix()
    {
        for (int i = 0; i < Rows; ++i)
        {
            for (int j = 0; j < Colomns; ++j)
            {
                Console.Write($"{Matrix[i, j]} ");
            }
            Console.WriteLine("");
        }
    }

    public static MyMatrix operator /(MyMatrix matrix, int number)
    {
        if (number == 0)
        {
            throw new Exception("Division by zero");
        }

        for (int i = 0; i < matrix.Rows; ++i)
        {
            for (int j = 0; j < matrix.Colomns; ++j)
            {
                matrix[i, j] /= number;
            }
            Console.WriteLine("");
        }

        return matrix;
    }

    public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
    {
        if (matrix1.Colomns != matrix2.Rows)
        {
            throw new Exception("The sizes of the matrix must match");
        }
        MyMatrix result = new MyMatrix(matrix1.Rows, matrix2.Colomns, matrix1.Range_of_numbers);
        for (int i = 0; i < matrix1.Rows; ++i)
        {
            for (int j = 0; j < matrix2.Rows; ++j)
            {
                result[i, j] = 0;
                for (int k = 0; k < matrix2.Colomns; ++k)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
    
    public int this[int row, int colomn]
    {
        get => Matrix[row, colomn];
        set
        {
            Matrix[row, colomn] = value;
        }
    }
}
