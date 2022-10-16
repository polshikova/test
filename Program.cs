using test;

List<PInfo> pInfos = new List<PInfo>();
Console.Write("Введите количество пользователей: ");
int countPeople = int.Parse(Console.ReadLine());
for (int i = 0; i < countPeople; i++)
{
    Console.WriteLine("Пользователь #" + (i + 1));
    pInfos.Add(new PInfo());
}

List<PInfo> foundPerson;
Console.WriteLine("По какому признаку найти людей?");
Console.Write("1 - имя, 2- пол: ");
bool mode = Console.ReadLine() == "1";
if (mode)
{
    Console.Write("Введите имя: ");
    string name = Console.ReadLine();
    foundPerson = Helper.SearchPerson(pInfos, name);
}
else
{
    Console.Write("Введите пол: ");
    bool gender = Console.ReadLine() == "1";
    foundPerson = Helper.SearchPerson(pInfos, gender);
}

PrintAllPeople(foundPerson);

//foreach (var item in pInfos)
//{
//    Console.WriteLine("============");
//    item.PrintInfo();
//    Console.WriteLine("============");
//}

void PrintAllPeople(List<PInfo>  infos)
{
    foreach (var item in infos)
    {
        Console.WriteLine("============");
        item.PrintInfo();
        Console.WriteLine("============");
    }
}
