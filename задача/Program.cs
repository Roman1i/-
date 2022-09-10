Console.Write("Введите колличество строк: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int array2Size = 0;

string[] strings = new string[arraySize];

for (int i = 0; i < strings.Length; i++) 
{
    Console.Write("Введите строку: ");
    strings[i] = Console.ReadLine();
    if ( strings[i].Length <= 3 ) array2Size++;
}
    
string[] strings2 = new string[array2Size];
int x = 0;

for (int i = 0; i < strings.Length; i++) 
{
    if ( strings[i].Length <= 3 ) 
        strings2[x++] = strings[i];
}

Console.WriteLine("[" + string.Join(", ", strings) + "]");
Console.WriteLine("[" + string.Join(", ", strings2) + "]");

