using ITKariera_Module4;

//1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
string tmp = "1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5";
CustomStack<int> a = new CustomStack<int>();
string stack = "";
for (int i = 0; i < tmp.Length; i++)
{
    char x = tmp[i];
    if (x == '(')
        a.Push(i);
    else if (x == ')')
    {
        int start = a.Pop();
        int lenght = i - start + 1;
        stack = tmp.Substring(start, lenght);
        Console.WriteLine(stack);
    }
}