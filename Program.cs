// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Tres matrices básicas
//Crea una matriz para contener los valores enteros 0 a 9.​
//Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​
//Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​

Console.WriteLine(" Matriz de némeros -------------------");
int [] numbers = new int [] {0,1,2,3,4,5,6,7,8,9};
foreach (int value in numbers)
{
    Console.WriteLine(value);
}
Console.WriteLine(" Matriz de string --------------------");

string []  names = new string [] {"Tim", "Martin", "Nikki" , "Sara"};
foreach (string name  in names)
{
    Console.WriteLine(name);
}

Console.WriteLine(" Matriz de bool --------------------");

bool []  booleans = new bool [10] {true, false, true, false, true, false, true, false, true, false};
foreach (bool boolean  in booleans)
{
    Console.WriteLine(boolean);
}
Console.WriteLine(" ista de Sabores --------------------");
//Lista de Sabores
//Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​
//Imprime la longitud de esta lista después de construirla. ​
//Imprime el tercer sabor de la lista y luego elimina ese valor. ​
//Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​

List<string> sabores = new List<string>();
sabores.Add("Chocolate");
sabores.Add("Vainilla");
sabores.Add("Fresa");
sabores.Add("Menta");
sabores.Add("Café");
sabores.Add("Achachairu");
foreach (string sabor in sabores)
{
    Console.WriteLine(sabor);
}
Console.WriteLine("Longitud de la lista  =>  "+ sabores.Count);
Console.WriteLine("Tercer sabor  =>  "+ sabores[2]);
sabores.RemoveAt(2);
Console.WriteLine("Lista de sabores sin el tercer sabor  --------=>");
foreach (string sabor in sabores)
{
    Console.WriteLine(sabor);
}

Console.WriteLine("Diccionario de Información del Usuario");
//Diccionario de Información del Usuario
//Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​
//Añade pares clave/valor a este diccionario donde:​
//cada clave sea un nombre de la matriz de nombres​
//cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
//Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​

Dictionary<string, string> informacionUsuarios  = new Dictionary<string, string>();
// Agregar elementos al diccionario
string[] nombres = { "Juan", "Pedro", "Luis", "José", "Lucio"};
for (int i = 0; i < nombres.Length; i++)
{
    informacionUsuarios[nombres[i]] = sabores[i];
}   

foreach (KeyValuePair<string, string>  kvp  in informacionUsuarios)
{
    Console.WriteLine($"Usuario: {kvp.Key}, Sabor de helado: {kvp.Value}");
}