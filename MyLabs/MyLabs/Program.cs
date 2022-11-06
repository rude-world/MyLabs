
using MyLabs.Classes;
List<int> labs = new List<int>();
labs.Add(1);
labs.Add(2);
labs.Add(3);
labs.Add(4);
labs.Add(5);
labs.Add(6);
labs.Add(7);

Console.WriteLine("Available labs:\n");
foreach (var item in labs)
{
    Console.WriteLine(item);
}
Console.WriteLine("\nEnter the lab number: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Lab1.Id();
        Lab1.Name();
        Lab1.Description();
        Lab1.Demo();
        break;
    case 2:
        Lab2.Id();
        Lab2.Name();
        Lab2.Description();
        Lab2.Demo();
        break;
    case 3:
        Lab3.Id();
        Lab3.Name();
        Lab3.Description();
        Lab3.Demo();
        break;
    case 4:
        Lab4.Id();
        Lab4.Name();
        Lab4.Description();
        Lab4.Demo();
        break;
    case 5:
        Lab5.Id();
        Lab5.Name();
        Lab5.Description();
        Lab5.Demo();
        break;
    case 6:
        Lab6.Id();
        Lab6.Name();
        Lab6.Description();
        Lab6.Demo();
        break;
    case 7:
        Lab7.Id();
        Lab7.Name();
        Lab7.Description();
        Lab7.Demo();
        break;

}
