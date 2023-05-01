string[] text = { "Hello", "!", "Geek", "Brains", "=D", "123" };

int size = Count(text);
string[] newText = new string[size];
Print(FillArray(text, newText));

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] FillArray(string[] array, string[] newArray)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[n] = array[i];
            n++;
        }
    }
    return newArray;
}

int Count(string[] str)
{
    int res = 0;

    for (int i = 0; i < str.Length; i++)
        if (str[i].Length <= 3) res++;

    return res;
}


