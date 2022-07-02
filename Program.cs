string Print(string[] array) 
{
    string res =string.Empty;
    int i = 0;
    res = "[ ";        
    for (; i < array.Length - 1; i++)
    {
        res += $"{array[i]}, ";
    }
    res += $"{array[i]} ]";        
    return res;
}

string[] arrayStrngs = new string[] { "12345", "hi", "hello", "sun", "good" };
Console.WriteLine($"Исходный массив: {Print(arrayStrngs)}");

string[] arrayLessLimit = Array.Empty<string>();
int limit = 3;
int i = 0;
for (int j = 0; j < arrayStrngs.Length; j++)
{
    if (arrayStrngs[j].Length <= limit)
    {
        Array.Resize(ref arrayLessLimit, i + 1);
        arrayLessLimit[i] = arrayStrngs[j];
        i++;
    }
}
Console.WriteLine($"Результирующий массив: {Print(arrayLessLimit)}");