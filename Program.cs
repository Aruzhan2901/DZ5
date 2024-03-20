// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//using System.Diagnostics.Contracts;
//using System.Runtime.InteropServices;

//int ReadInt (string msg)
//{
//    System.Console.WriteLine(msg);
//    return Convert.ToInt32(System.Console.ReadLine());

//}

//int BiggerOne(int M, int N)
//{
//    if(M > N)
//    {
//        return M;
//    }
//    else
//        return N;
//}

//int SmallerOne(int M, int N)
//{
//    if(N>M)
//    {
//        return M;
//    }
//    else
//        return N;
//}

//void PrintNumbers(int M,int N)
//{
//    if(SmallerOne(M,N)>=BiggerOne(M,N))
//    {
//        System.Console.WriteLine(SmallerOne(M,N)+"");
//        return;
//    }
//    PrintNumbers(SmallerOne(M,N), (BiggerOne(M,N)-1));
//    System.Console.WriteLine(BiggerOne(M,N)+"");
//}

//int N = ReadInt("Enter N");
//int M = ReadInt("Enter M");
//PrintNumbers(N,M);


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//int ReadInt(string msg)
//{
//    System.Console.WriteLine(msg);
//    return Convert.ToInt32(System.Console.ReadLine());
//}

//int A(int m,int n)
//{
//    if(m == 0)
//    {
//        return n + 1;
//    }
//    if(n == 0)
//    {
//        return A(m - 1, 1);
//    }
//    else
//    {
//        return A(m - 1, A(m, (n - 1)));
//    }

//}

//int n = ReadInt("Enter n");
//int m = ReadInt("Enter m");
//System.Console.WriteLine(A(n,m));

// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

//int[]numbers = new int[] {4,5,6,7,10,15};
//void PrintArray(int[] array,int index)
//{
//    if(index >= array.Length)
//    {
//        return;
//    }
//    else
//    {
//        PrintArray(array,index+1);
//        System.Console.Write(array[index] + "");
//    }
//}
//PrintArray(numbers,0);