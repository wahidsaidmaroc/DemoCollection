using ClassLibrary;


Helper helper = new Helper();

Console.WriteLine("La list des client est : ");
foreach (var item in helper.getListClient())
{
    Console.WriteLine(item.id + "-" + item.nomCLient);
}


Console.WriteLine("Liste des client Casa");

//Linq 
var listCasa = (from a in helper.getListClient()
               where a.ville == "Casa" 
               select a.nomCLient).ToList();


https://github.com/wahidsaidmaroc/DemoCollection


var listeCasaMethode = helper.getListClient()
    .Where(a => a.ville == "Casa")
    .Select(a => a.nomCLient)
    .ToList();


foreach (var item in listCasa)
{
    Console.WriteLine(item);
}