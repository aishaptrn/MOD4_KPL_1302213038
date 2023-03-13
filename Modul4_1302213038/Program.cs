// See https://aka.ms/new-console-template for more information

public class KodeBuah
{
    public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry,
        Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka};
    public static string getKodeBuah(namaBuah buah)
    {
        string[] kodeBuah = { "A00", "B00" , "C00" , "D00" , "E00" , "F00" , 
            "G00" , "H00", "I00" , "J00" , "K00" , "L00" , "M00" , "N00" , "O00" };
        return kodeBuah[(int)buah];
    }
}

public class PosisiKarakterGame
{
    public enum State { Berdiri, Tengkurap, Terbang, Jongkok };

    public static void Main()
    {
        KodeBuah kodeBuah = new KodeBuah();
        string getKdb = KodeBuah.getKodeBuah(KodeBuah.namaBuah.Anggur);
        Console.WriteLine("Kode buah Anggur adalah " + getKdb + ".\n");

        State state = State.Berdiri;
        string[] outputLabel = { "posisi take off", "posisi landing"};

        while (state != null)
        {
            Console.WriteLine(outputLabel[])
        }
    }
}