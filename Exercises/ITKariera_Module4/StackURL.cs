using ITKariera_Module4;
CustomStack<string> history = new CustomStack<string>();
string tmp;
do
{
    tmp = Console.ReadLine();
    switch (tmp)
    {
        case "back":
            if (history.Count == 0) break;
            Console.WriteLine(history.Pop());
            Console.WriteLine(history.Peek());
            break;
        case "exit": break;
        default:
            history.Push(tmp);
            break;
    }
} while (tmp != "exit");