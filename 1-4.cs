// リストコレクション
// リスト型を使用したデータ コレクションの管理について説明します

var names = new List<string> { "<name>", "Ana", "Felipe" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine();
Console.WriteLine($"My name is {names[0]}."); // => <name>

Console.WriteLine();
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list."); // => Maria Bill

Console.WriteLine();
Console.WriteLine($"The list has {names.Count} people in it"); // => error: The list has 4 people in it

// 項目がインデックスにない場合、IndexOfは-1を返す
Console.WriteLine();
var index = names.IndexOf("Felipe");
if (index != -1)
  Console.WriteLine($"The name {names[index]} is at index {index}");

Console.WriteLine();
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

Console.WriteLine();
names.Sort(); // Sortメソッド：　全ての項目を正規順序（文字列の場合はアルファベット順）に並び替え
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}


// フィボナッチ数 n=20 まで
var fibonacciNumbers = new List<int> {1, 1};
for (int i = 2; i < 20; i++)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"{i+1}: {fibonacciNumbers[i]}");
}
// foreach版
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);
