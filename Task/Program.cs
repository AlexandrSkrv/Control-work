// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] array = new string[] { "ta", "tas", "task", "task1", "t", "ttw" };
string[] newArray = new string[array.Length];
int count = 0;

void checkingTheCondition(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      newArray[count] = array[i];
      count++;
    }
  }
}
void Print(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
checkingTheCondition(array);
Print(newArray);

