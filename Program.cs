string[] array = new string[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine()!;
}
Console.Write("[" + string.Join(", ", array) + "]");

string[] resalt = new string[array.Length];
int count = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resalt[count] = array[i];
        count ++;
    }
}
Console.WriteLine(" -> [" + string.Join(", ", resalt) + "]");