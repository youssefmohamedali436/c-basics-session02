//Q1
string name = "p";
int pages = 5;
int pages = 464;
Console.WriteLine($"Title:{title} and pages {pages} ");

Console.WriteLine(title.GetHashCode());
Console.WriteLine(name.GetHashCode());

Console.WriteLine(title.Equals(name));//False

//Q4
int i = 10;
int j = 0;
try
{
    int result = i / j;

}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally {
    Console.WriteLine("Done");

}
//Q5
int page = 500;
double p = page;
Console.WriteLine($"{p}");

//Q6
double price = 49.99;
int price1 = (int)price;
Console.WriteLine($"{price1}");

//Q7
string pagesText = "464";
int pagesText1 = Convert.ToInt32(pagesText);
Console.WriteLine($"{pagesText1}");

//Q8
string yearText = "2023";
int yearText1 = int.Parse(yearText);
Console.WriteLine($"{yearText1}");

string badText = "abc";
if (!int.TryParse(badText, out int number))
{
    Console.WriteLine("Invalid number");
}

//Q9
int pages_Q9 = 464;
string p1 = pages_Q9.ToString();
Console.WriteLine(p1.GetType());

//Q10
int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;
Console.WriteLine(boxed);
Console.WriteLine(unboxed);



