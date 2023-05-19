using PilotakOsztaly;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Pilotak> PilotaLista = new List<Pilotak>();
        StreamReader sr = new StreamReader("pilotak.csv");
        sr.ReadLine();

        while (!sr.EndOfStream)
        {
            string[] pilota = sr.ReadLine().Split(";");
            PilotaLista.Add(new Pilotak(pilota[0], pilota[1], pilota[2], int.Parse(pilota[3])));
        }
        sr.Close();

        Console.WriteLine($"3.feladat: {PilotaLista.Count()}");
    }
}