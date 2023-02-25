//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
//натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Clear();

System.Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());


int PowNumber(int num1, int num2){
    int power = 1;
for(int i = 0; i<num2; i++){
power*=num1;
}
return power;
}
System.Console.WriteLine($"Число {PowNumber(a, b)}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.Clear();

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Summ(int number){
 int result = 0;

 while(number>0){

    result+=number%10;
    number/=10;
    
 }
 return result;
}
System.Console.WriteLine($"Сумма чисел: {Summ(a)}");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int n=8;
int[] arr = new int[n];
Random rand = new Random();

for(int i = 0; i<arr.Length; i++){
    
    arr[i] = rand.Next(1,100);
    
}

Console.Write("[");
System.Console.WriteLine(string.Join(",", arr));
Console.Write("]");
