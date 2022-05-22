Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

void Rec (int n)
{
    if(n<m)
    return;
    Console.Write(n + " ");
    Rec(n-1);
}
Rec(n);