//  Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

while (true) {
Console.WriteLine("Программа проверяет явлется ли число палиндромом.\nВведите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

string str = number.ToString();

// if ((str.Length > 5 && str[0] != '-') || (str.Length > 6 && str[0] == '-'))
if (str.Length == 6 && str[0] == '-'){
    Console.WriteLine($"{number} -> нет"); 
}

if (str.Length == 5 && str[0] != '-'){
    if (str[0] == str[4] && str[1] == str[3]){
        Console.WriteLine($"{number} -> да"); 
        }
    if (str[0] != str[4] || str[1] != str[3]){
        Console.WriteLine($"{number} -> нет"); 
        }
}

if ((str.Length == 6 && str[0] != '-') || str.Length < 5 || str.Length > 7){
    Console.WriteLine("Неверный формат ввода"); 
}
}