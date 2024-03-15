// Напишите программу, которая на вход принимает
// натуральное число N, а на выходе показывает
// цифры через запятую.
//  568 => 5,6,8
//  8   => 8
//  9542=> 9,5,4,2



Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} =>");
int numBuild = num;
int count = 1;
while (numBuild != 0)
{

    numBuild /= 10;
    
    count += 1;
}

int numRange = 1;
int exponent = count - 1;
int baseNum = 10;

for (int i = 1; i < exponent; i++)
{
    numRange *= baseNum;
}

int count_1 = 1;
int numFig = 0;
int numBase = num;


while (count_1 <= exponent)
{

    numFig = numBase / numRange;

    numBase %= numRange;
    numRange /= 10;

    count_1 += 1;
    Console.Write($" ,{numFig}  ");
}
