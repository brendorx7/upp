
Console.WriteLine("digite sua idade : ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 12)
{
    Console.WriteLine("voce é crianca ");
}

else if (a <= 17)

{
    Console.WriteLine("adolescente");

}

else if (a <= 59)
{
    Console.WriteLine("adulto");

}
else
{
    Console.WriteLine("idoso");

}