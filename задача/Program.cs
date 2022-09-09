Console.Write("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

string[] strings = new string[n];

for (int i = 0; i < n; i++) 
{
    Console.Write("Введите строку: ");
    strings[i] = Console.ReadLine();
    if ( strings[i].Length <= 3 ) count++;
}
    
string[] strings2 = new string[count];
int x = 0;

for (int i = 0; i < n; i++) 
{
    if ( strings[i].Length <= 3 ) 
        strings2[x++] = strings[i];
}

Console.WriteLine("[" + string.Join(", ", strings) + "]");
Console.WriteLine("[" + string.Join(", ", strings2) + "]");

