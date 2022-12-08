using System.IO;
StreamReader input = new StreamReader("talfil.txt");
List<string> Rader = new List<string>();
string rad = "";
while ((rad = input.ReadLine()) !=null)
{
    Rader.Add(rad);
}
input.Close();

int total = Rader.Sum(rad => Convert.ToInt32(rad));
Console.WriteLine(total);
int total2 = Rader.Where(rad=>(Convert.ToInt32(rad)%2)==0).Sum();
Console.WriteLine(total2);