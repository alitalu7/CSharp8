
Console.WriteLine("Sayıyı giriniz...");
int sayi = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i <= sayi)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
        i++;
    }
}