// C#における数値　C# で整数と浮動小数点数を操作する

/*
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

c = a * b;
Console.WriteLine(c);

c = a / b;
Console.WriteLine(c);
*/
/*
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);
*/

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

// 整数型の最大値最小値
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// オーバーフロー（最大値から最小値に折り返された）
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

/*
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);
*/

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
Console.WriteLine(third * 3);

// decimal: doubeよりも範囲小さい、有効桁数大きい
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);
Console.WriteLine(a / b * b); // => 1

// 数字の末尾に M
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
Console.WriteLine(c / d * d); // => 0.99999....

// 半径2.50の円の面積
double pi = Math.PI;
double r = 2.50;
double S = pi * r*r;
Console.WriteLine(S);