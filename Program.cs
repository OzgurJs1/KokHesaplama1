int a, b, c;
double delta,x1,x2;
Console.WriteLine("A değerini giriniz = ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B değerini giriniz = ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("C değerini giriniz = ");
c = Convert.ToInt32(Console.ReadLine());
delta = b * b - 4 * a * c;
if(delta == 0)
{
    Console.WriteLine("Kökler eşit!");
}
else if(delta < 0)
{
    Console.WriteLine("Kök yok!");
}
else
{
    x1 = ((-1) * b - Math.Sqrt(delta)) / 2 * a;
    x2 = ((-1) * b - Math.Sqrt(delta)) / 2 * a;
    Console.WriteLine("x1 = {0},x2 = {1}", x1, x2);
}