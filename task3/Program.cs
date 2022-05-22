Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n) 
{
    if(m == 0) return n + 1;
    if(n == 0) return Ack(m - 1, 1); 
    return Ack(m - 1, Ack(m, n - 1));
}
Console.WriteLine($"Значение функции Аккермана: A({m}, {n}): {Ack(m, n)}.");