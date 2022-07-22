//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Number(int[] number)
{
  int brush = 0;
  int length = number.Length;
  while (brush <  length)
  {
    number[brush] = Convert.ToInt32(Math.Pow(brush, 3));
    brush++;
  }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        Console.WriteLine(col[index]+ " ");
        index++;
    }

}

int[] array=new int[number + 1];
//array[0]=0;
//array[1]=1;
//int index = 2;
//while(index<N)
//{
    //array[index] = array[index -1]+array[index-2];
    //index++;
//}
Number(array);
PrintArray(array);
// 3 Семинар))

