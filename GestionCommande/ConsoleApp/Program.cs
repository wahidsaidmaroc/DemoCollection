using ClassLibrary;

Helper helper = new Helper();

Console.WriteLine("La list des client est : ");
foreach (var item in helper.getListClient())
{
    Console.WriteLine(item.id + "-" + item.nomCLient);
}