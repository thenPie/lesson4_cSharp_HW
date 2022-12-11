Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

string str = num.ToString();
int numLength = str.Length;

for(int i = 0; i < numLength; i++) {
    int sum1 = int.Parse((str[i].ToString()));
    sum = sum + sum1;
}

Console.WriteLine(sum);