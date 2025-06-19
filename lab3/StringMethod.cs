
////5. Write program showing use of common methods of String class. 

string text1 = "Hello World";
string text2 = "Darshan University";

Console.WriteLine("Upper of string:"+text1.ToUpper());
Console.WriteLine("Lower of string:"+text2.ToLower());
Console.WriteLine("Trim"+text1.Trim());
Console.WriteLine( "length of string:"+text2.Length);
Console.WriteLine("replace the word:"+text1.Replace("World","Everyone"));
Console.WriteLine("substring:"+text2.Substring(2,5));
Console.WriteLine("StartsWith:"+text1.StartsWith('n'));
Console.WriteLine("endswith:"+text2.EndsWith('y'));
Console.WriteLine("Concat the string"+String.Concat(text1 + text2));
Console.WriteLine("index of string:"+text2.IndexOf('n'));




