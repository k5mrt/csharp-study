// 分岐とループ
// 分岐およびループ ステートメントを使用した条件付きロジックについて説明します

int b = 6;
if (a + b > 10)
    Console.WriteLine($"The answer: {a + b} is greater than 10.");

b = 3;
if (a + b < 10)
    Console.WriteLine($"The answer: {a + b} is less than 10.");

int a = 5;
int b = 3;
if (a + b > 10) {
    Console.WriteLine($"The answer: {a + b} is greater than 10");
}
else {
    Console.WriteLine($"The answer: {a + b} is not greater than 10");
}

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

Boolean a;

if (a = (true && false) )
{
    Console.WriteLine($"&&: {a}");
}

if ( a = (true || false) )
{
    Console.WriteLine($"||: {a}");
}
if ( a = (false || true) )
{
    Console.WriteLine($"||: {a}");
}

/*
int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}
*/

// do は最初にコードを実行してから条件を確認
int counter = 10;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);


/*
for(int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}
*/

// 行
for (int row = 1; row < 11; row++)
{
  Console.WriteLine($"The row is {row}");
}

// 列
for (char column = 'a'; column < 'k'; column++)
{
  Console.WriteLine($"The column is {column}");
}

// 行列
for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}


// 1 から 20 の整数のうち 3 で割り切れる数の合計を求める

int sum = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        sum += i;
    }
}
Console.Write(sum); // => 63