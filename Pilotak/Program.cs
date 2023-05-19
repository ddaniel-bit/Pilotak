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
            if (pilota[3] == "")
            {
                PilotaLista.Add(new Pilotak(pilota[0], pilota[1], pilota[2], 0));
            }
            else
            {
                PilotaLista.Add(new Pilotak(pilota[0], pilota[1], pilota[2], int.Parse(pilota[3])));
            }

        }
        sr.Close();

        Console.WriteLine($"3. feladat: {PilotaLista.Count()}");
        Console.WriteLine($"4. feladat: {PilotaLista.Last().Nev}");
        Console.WriteLine("5. feladat:");
        for (int pilotaindex = 0; pilotaindex < PilotaLista.Count(); pilotaindex++)
        {
            string[] ev_ho_nap = PilotaLista[pilotaindex].Szuletesidatum.Split(".");
            int ev = int.Parse(ev_ho_nap[0]);
            if (1901 > ev)
            {
                Console.WriteLine($"\t{PilotaLista[pilotaindex].Nev} ({PilotaLista[pilotaindex].Szuletesidatum})");
            }
        }
        int legkisebb = PilotaLista[0].Rajtszam;
        int legkisebbIndex = 0;
        for (int pilotaindex = 0; pilotaindex < PilotaLista.Count(); pilotaindex++)
        {
            int rajtszam = PilotaLista[pilotaindex].Rajtszam;
            if (rajtszam < legkisebb && rajtszam != 0)
            {
                legkisebb = rajtszam;
                legkisebbIndex = pilotaindex;
            }
        }
        Console.WriteLine($"6. feladat: {PilotaLista[legkisebbIndex].Nemzetiseg}");
        List<int> votma = new List<int>();
        List<int> votma2 = new List<int>();
        for (int pilotaindex = 0; pilotaindex < PilotaLista.Count(); pilotaindex++)
        {
            int rajtszam = PilotaLista[pilotaindex].Rajtszam;
            if (!votma.Contains(rajtszam))
            {
                votma.Add(rajtszam);
            }
            else
            {
                if (!votma2.Contains(rajtszam))
                {
                    votma2.Add(rajtszam);
                }
            }
        }
        votma2.Remove(0);
        string output = "7. feladat: "+string.Join(", ", votma2);
        Console.WriteLine(output);

    }
}