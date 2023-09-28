Console.WriteLine("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < n)
{
    count=count + 2; 
    Console.WriteLine(count);
}
