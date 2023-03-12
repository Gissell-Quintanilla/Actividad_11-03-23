Console.WriteLine("Ingrese un número: ");
int Triángulo = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= Triángulo; i++)
{
    String temp = "";
    for (int t = 1; t <= i; t++) 
    {
        temp += "*";
    }
    Console.WriteLine(temp);
}   
