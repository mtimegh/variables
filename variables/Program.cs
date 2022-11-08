int a;
string b;
double c;

a = 10;
b = "to jest tekst";
c = 10.11;


Console.WriteLine("To jest double {0}",c);
Console.WriteLine("To jest string {0} ", b);
Console.WriteLine(" to jest int {0} ", a);

a = Int32.Parse(Console.ReadLine());
b = Console.ReadLine();
c = Double.Parse(Console.ReadLine());

Console.WriteLine(c + " " + b + " " + a);