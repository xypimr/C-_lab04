namespace task01;

public class Matrix
{
    private  int[][] _matrix;
    public static int Min { get; set; }
    public static int Max { get; set; }
    
    public Matrix(int m, int n)
    {
        Random rnd = new Random();
        _matrix = new int[m][];
        for (int i = 0; i < m; i++)
        {
            _matrix[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                _matrix[i][j] = rnd.Next(Min, Max);
            }
        }
    }


    public void Print()
    {
        string text = "";
        for (int i = 0; i < _matrix.Length; i++)
        {
            for (int j = 0; j < _matrix[i].Length; j++)
            {
                text += $"{_matrix[i][j]}\t";
            }

            text += '\n';
        }

        Console.WriteLine(text);
    }
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
    
        Matrix ans = new Matrix(m1._matrix.Length, m2._matrix[0].Length);
        for (int i = 0; i < ans._matrix.Length; i++)
        {
            for (int j = 0; j < ans._matrix[i].Length; j++)
            {
                ans._matrix[i][j] = m1._matrix[i][j] + m2._matrix[i][j];
            }
        }
        return ans;
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        Matrix ans = new Matrix(m1._matrix.Length,m1._matrix[0].Length);
        for (int i = 0; i < ans._matrix.Length; i++)
        {
            for (int j = 0; j < ans._matrix[i].Length; j++)
            {
                ans._matrix[i][j] = m1._matrix[i][j] - m2._matrix[i][j];
            }
        }

        return ans;
    }
    static public Matrix operator *(Matrix m1, Matrix m2)
    {
        Matrix ans = new Matrix(m1._matrix.Length, m1._matrix[0].Length);
        for (uint i = 0; i < m1._matrix.Length; ++i)
        {
            for (uint j = 0; j < m1._matrix[0].Length; ++j)
            {
                for (uint n = 0; n < m2._matrix.GetUpperBound(0) + 1; ++n)
                {
                    ans._matrix[i][j] += m1._matrix[i][n] * m2._matrix[n][j];
                }
            }
        }
        return ans;
    }
    public static Matrix operator *(Matrix m1, int bx)
    {
        Matrix ans = new Matrix(m1._matrix.Length,m1._matrix[0].Length);
        for (int i = 0; i < ans._matrix.Length; i++)
        {
            for (int j = 0; j < ans._matrix[i].Length; j++)
            {
                ans._matrix[i][j] = m1._matrix[i][j]*bx;
            }
        }

        return ans;
    }
    public static Matrix operator /(Matrix m1, int a)
    {
        Matrix ans = new Matrix(m1._matrix.Length,m1._matrix[0].Length);
        for (int i = 0; i < ans._matrix.Length; i++)
        {
            for (int j = 0; j < ans._matrix[i].Length; j++)
            {
                ans._matrix[i][j] = m1._matrix[i][j]/a;
            }
        }

        return ans;
    }
    public int this[int m1, int m2]
    {
        get
        {
            return _matrix[m1][m2];
        }
    }
}