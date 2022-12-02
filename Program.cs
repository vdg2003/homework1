string[] array = new string[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine()!;
}
Console.Write("[" + string.Join(", ", array) + "]");
