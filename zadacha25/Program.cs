// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Write("Введите число, которое необходимо возвести в степень: ");
int num = int.Parse(Console.ReadLine());
int original = num;
Console.Write("Введите степень числа: ");
int up = int.Parse(Console.ReadLine()) - 1;

for(int i = 0; i < up; i++) {
    // Console.WriteLine(num);
    num = num * original;
    // Console.WriteLine(num);
}

Console.WriteLine(num);