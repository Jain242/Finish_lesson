

 void PrintArray(string [] array){
 System.Console.Write("[");
int n = array.Length;
if (n == 0) System.Console.WriteLine("]");
 for (int i = 0; i < n; i++)
{if(i == n-1)
   System.Console.WriteLine($"{array[i]}]");
 else System.Console.Write($"{array[i]}, ");
 }
}


void EnterArray(string [] array, int n){
   
for (int i = 0; i < n; i++)
{array [i] = Convert.ToString(Console.ReadLine());
}
}


System.Console.WriteLine("Итоговая проверочная работа");
System.Console.Write("Введите колличество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0){System.Console.WriteLine("Ввели отрицательное число!!!");
return;}
string [] array = new string [a];
System.Console.WriteLine("Эллементы массива через Enter");
EnterArray(array,a);
PrintArray(array);