//Hello World - C# の概要に関する対話型チュートリアル

Console.WriteLine("Hello World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maria";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);

Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friend are {firstFriend} and {secondFriend}");
// 文字列補間

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
// Length は文字列のプロパティ

string greeting = "     Hello World!     ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
// 先頭のスペースをトリミング

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
// 末尾のスペースをトリミング

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
// 先頭と末尾のスペースをトリミング

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
// "Hello" を　"Greetings" に置換
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper()); // 大文字に変換
Console.WriteLine(sayHello.ToLower()); // 小文字に変換

string songLyrics = "You say goodbye, and I say hello";
// 文字列内を検索
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
Console.WriteLine(songLyrics.Contains("Goodbye")); // 大文字小文字は区別

// 先頭の部分文字列を検索
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
// 末尾の部分文字列を検索
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));