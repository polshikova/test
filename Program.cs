using test;
List<PInfo> pInfos = new List<PInfo>();
Console.Write("Введите количество пользователей: ");
int countPeople = int.Parse(Console.ReadLine());
for (int i = 0; i < countPeople; i++)
{
    Console.WriteLine("Пользователь #" + (i + 1));
    pInfos.Add(new PInfo());
}

Console.WriteLine("По какому признаку найти людей?");
Console.WriteLine("1 - имя, 2- пол: ");
bool mode = Console.ReadLine() == "1";
if (mode)
{
    Helper.SearchPerson(pInfos);
}



//foreach (var item in pInfos)
//{
//    Console.WriteLine("============");
//    item.PrintInfo();
//    Console.WriteLine("============");
//}
