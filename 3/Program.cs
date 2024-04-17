   // Задайте произвольный массив. Выведете его элементы, начиная с конца. 
   // Использовать рекурсию, не использовать циклы.
   
    
 int [] MyArray = GenerateArray(25, 10, 60);
 PrintArray(MyArray);
 PrintNumbers(MyArray,25);

        
int [] GenerateArray ( int size, int LeftRange, int RightRange)
{
int [] tempArrray = new int [size];
Random rand = new Random();
for (int i =0; i < size; i++)
{
    tempArrray[i] = rand.Next(LeftRange,RightRange + 1);
}
return tempArrray;

}

void PrintArray (int[]arrayforprint)
{

    System.Console.WriteLine(string.Join(", ", arrayforprint));
}

 void PrintNumbers(int[] Array, int size) 
 {
  if ( size == 0) return;
 {
  System.Console.Write($"{Array[size-1]} "+ " ");
  PrintNumbers(Array, size - 1);
  }

}


    
