namespace TMS_HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы ");
            Console.WriteLine("Количество строк:");
            int lines = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Количество столбцов");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[lines, columns];

            for (int i = 0; i <= arr.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = Random.Shared.Next(-99, 99);
                    Console.Write(arr[i,j] + "   ");
                }
                Console.WriteLine( );
            }
            Console.WriteLine();
            int sumPlus = 0;
            int sumMinus = 0;
            Console.WriteLine("Что вы хотите сделать:\n1) Посчитать количество пололжительных и отрицательных чисел");
            Console.WriteLine("2) Сортировать элементы матрицы в каждой строке от большего к меньшему");
            Console.WriteLine("3) Инверсия элементов матрицы в каждом столбце");
            Console.WriteLine("4) Выход");
      
            while(true) 
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    for (int i = 0; i <= arr.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= arr.GetUpperBound(1); j++)
                        {
                            if(arr[i, j] > 0 && arr[i,j]!= 0)
                            {
                                sumPlus++;
                            }
                            else if (arr[i,j] < 0)
                            {
                                sumMinus++; 
                            }
             
                        }
                    }
                    Console.WriteLine($"Количество положительных:{sumPlus}\n Количество отрицательных:{sumMinus}");       
                }
                else if (choice == 2)
                {
                    for (int i = 0; i <= arr.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j < arr.GetUpperBound(1); j++)
                        {
                            for (int k = 0; k < arr.GetUpperBound(1) - j; k++)
                            {
                                if (arr[i, k] < arr[i, k + 1])
                                {
                                    int newArr = arr[i, k];
                                    arr[i, k] = arr[i, k + 1];
                                    arr[i, k + 1] = newArr;
                                }
                            }
                        }
                        
                    }
                    Console.WriteLine("Сортированная матрица выгдялит так:");
                    for (int i = 0; i <= arr.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= arr.GetUpperBound(1); j++)
                        {
                            Console.Write(arr[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (choice == 3)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        for (int i = 0; i < arr.GetLength(0) / 2; i++)
                        {
                            int newArr = arr[i, j];
                            arr[i, j] = arr[arr.GetLength(0) - 1 - i, j]; 
                            arr[arr.GetLength(0) - 1 - i, j] = newArr;
                        }
                    }
                    Console.WriteLine("Инвертированная матрица выгдялит так:");
                    for (int i = 0; i <= arr.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j <= arr.GetUpperBound(1); j++)
                        {
                            Console.Write(arr[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите число строго от 1 до 4!");
                }
                
            }
            Console.WriteLine("Конец программы.");
        }
    }
}
