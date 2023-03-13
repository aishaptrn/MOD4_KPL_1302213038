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
    public enum State { berdiri, tengkurap, terbang, jongkok };

    public static void Main()
    {
        KodeBuah kodeBuah = new KodeBuah();
        string getKdb = KodeBuah.getKodeBuah(KodeBuah.namaBuah.Anggur);
        Console.WriteLine("Kode buah Anggur adalah " + getKdb + ".\n");

        State state = State.berdiri;
        string[] outputLabel = { "Berdiri", "Tengkurap", "Terbang", "Jongkok"};
        /*string[] outputLabel = { "posisi standby", "posisi istirahat",
            "posisi take off", "posisi landing"};*/

        while (state != null)
        {
            Console.WriteLine(outputLabel[(int) state]);
            Console.Write("Enter Button: ");

            string input = Console.ReadLine();
            switch (state)
            {
                case State.berdiri:
                    if (input == "S")
                    {
                        state = State.jongkok;
                    } else if (input == "W")
                    {
                        state = State.terbang;
                        Console.WriteLine("posisi take off\n");
                    } else
                    {
                        state = State.berdiri;
                        Console.WriteLine("Invalid input!\n");
                    }
                    break;

                case State.terbang:
                    if (input == "X")
                    {
                        state = State.jongkok;
                        Console.WriteLine("posisi landing\n");
                    } else if (input == "S")
                    {
                        state = State.berdiri;
                    } else
                    {
                        state = State.terbang;
                        Console.WriteLine("Invalid input!\n");
                    }
                    break;
            }
        }
    }
}