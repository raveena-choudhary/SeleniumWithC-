// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a =4;
Console.WriteLine("a = " + a);

String s1 = "hello";
String s2 = new String("hello");
Console.WriteLine(s1 == s2);
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(object.ReferenceEquals(s1, s2));