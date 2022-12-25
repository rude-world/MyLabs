using MyLabs;
using MyLabs.Classes;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;

List<Ilabs> _labs = new List<Ilabs>();

Assembly asm = Assembly.LoadFrom("ClassLibrary1.dll");
Type[] types = asm.GetTypes();
foreach (Type type in types)
{
    if ((type.IsInterface == false) && (type.IsAbstract == false))
    {
        if (type.GetInterface("Ilabs") != null)
        {
            Ilabs lab = (Ilabs)Activator.CreateInstance(type);
            _labs.Add(lab);
        }
    }
}
foreach (var lab in _labs)
{
    Console.WriteLine(lab);
}
 

bool running = true;

while (running)                // запускаем бесконечный цикл
{
    Console.Write("Введите ID лабораторной: ");
    string command = Console.ReadLine();

    switch (command)
    {
        case "clear":
            Clear();
            break;
        case "info":
            LabsInfo(_labs);
            break;

        case "help":
            Help();
            break;
        case "exit":
            running = false;
            break;
        default:
            {
                Demo(_labs, command);
            }
            break;
    }
}
    

    /// <summary>
    /// Метод запускает Demo по введенному ID
    /// </summary>
   
    static void Demo(List<Ilabs> _labs, string id)
{
    try
    {
        int ID = Convert.ToInt32(id);
        foreach (Ilabs lab in _labs)
        {
            if (ID == lab.Id())
            {
                lab.Demo();
            }
        }
    }
    catch
    {
        Console.WriteLine("Неверная команда. Попробуйте еще раз.");
    }
}

/// <summary>
/// Метод выводит информацию обо всех доступных лабораторных
/// </summary>
/// <param name="labs"></param>
static void LabsInfo(List<Ilabs> _labs)
{
    foreach (Ilabs lab in _labs)
    {
        Console.WriteLine(lab.Id());
        Console.WriteLine(lab.Name());
        Console.WriteLine(lab.Description());
        Console.WriteLine();
    }
}

/// <summary>
/// Метод очищает экран
/// </summary>
static void Clear()
{
    Console.Clear();
}

/// <summary>
/// Метод выводит все доступные команды
/// </summary>
static void Help()
{
    string[] commands =
    {
            "<ID> - запуск демонстрации лабораторной по ID",
            "<exit> - выход",
            "<help> - список доступных команд",
            "<clear> - очистка экрана",
            "<info> - вывод информации о всех лабораторных"
    };

    foreach (string command in commands)
    {
        Console.WriteLine(command);
    }
}
