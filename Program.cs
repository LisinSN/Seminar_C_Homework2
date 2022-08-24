//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("");
Console.WriteLine ("Давайте определим вторую цифру в случайном числе");

// Вычленение цифры. Метод возвратный
int Exarticulation(){
    int num = new Random().Next(100,1000);
    Console.WriteLine ("Случайное число: " + num);
    int figure = num /10 % 10;
    Console.WriteLine ("Вторая цифра заданного числа: " + figure);   
    return figure;
}
Exarticulation();


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine ("");
Console.WriteLine ("Давайте определим треью цифру в введенном числе");

// Вычленение цифры. Метод возвратный
int Exarticulation2(int num){
    int figure = num % 10;
    return figure;
}
// Ввод данных
Console.Write ("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100){
    Console.WriteLine ("Третьей цифры нет");
}
else {
    while (num > 999){
        num= num/10;
    }
    Console.WriteLine ("Трятья цифра " + Exarticulation2(num));
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine ("");
Console.WriteLine ("Давайте определим является ли выходным днем день недели");

// Вычленение цифры. Метод возвратный
int Week(int numday){
    if(numday < 1 || numday > 7){
        Console.WriteLine ("Нет такого дня недели ");
    }
    else if (numday == 6 || numday == 7) {
        Console.Write ("Это выходной");
    }
    else {
        Console.Write ("Не выходной");
    }
    return numday;
}
// Ввод данных
Console.Write ("Введите день недели: "); 
int numday = Convert.ToInt32(Console.ReadLine());

Week(numday);