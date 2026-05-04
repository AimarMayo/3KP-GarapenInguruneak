namespace _3POO_5
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The lp
        /// </summary>
        static List<Porra> lp = new List<Porra>();
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        static void Main()
        {
            int eragiketa;          
            FitxategiaIrakurri();           
            {
                do
                {
                    Console.WriteLine("***** PORRA ***********");
                    Console.WriteLine("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");
                    Console.WriteLine("1.- Egungo porra ikusi");
                    Console.WriteLine("2.- Emaitzak sartu");
                    Console.WriteLine("3.- IRTEN");
                    eragiketa = int.Parse(Console.ReadLine());
                    switch (eragiketa)
                    {
                        case 1:                           
                            InprimatuPorrak();
                            break;
                        case 2:                          
                            SartuEmaitzak();
                            break;
                        case 3:                           
                            FitxategiraPuntuak();
                            return;
                        default:
                            Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                            break;
                    }
                } while (eragiketa != 3);
            }
        }
        /// <summary>
        /// Sartus the emaitzak.
        /// </summary>
        static void SartuEmaitzak()
        {
            Console.WriteLine("Zein izan dira gaurko bi arerioak, finalistak?");
            string are1 = Console.ReadLine();
            string are2 = Console.ReadLine();           
            FinalisteiPuntuEguneraketa(are1, are2);
            Console.WriteLine("Eta zein izan da irabazlea? Enpate egon bada sakatu intro");
            string ir = Console.ReadLine();          
            IrabazleeiPuntuEguneraketa(ir);           
            int golkop = lortugolak();
            for (int i=1; i <= golkop; i++)
            {
                Console.WriteLine("Sartu " + i + ". golaren egilea:");
                string goleatzaile = Console.ReadLine();               
                GoleatzaileenPuntuEguneraketa(goleatzaile);
            }
        }
        /// <summary>
        /// Lortugolaks this instance.
        /// </summary>
        /// <returns></returns>
        static int lortugolak()
        {
            while (true)
            {
                Console.WriteLine("Zenbat gol egon dira gaur?");
                try
                {
                    int golkop = int.Parse(Console.ReadLine());
                    return golkop;
                }
                catch
                {
                    Console.Write("Zenbaki desegokia...");
                }
            }
        }
        /// <summary>
        /// Irabazleeis the puntu eguneraketa.
        /// </summary>
        /// <param name="ir">The ir.</param>
        static void IrabazleeiPuntuEguneraketa(string ir)
        {
            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].Irabazlea == ir)
                {
                    lp[i].Puntuak = lp[i].AsmatuIrabazlea();
                }
            }
        }
        /// <summary>
        /// Finalisteis the puntu eguneraketa.
        /// </summary>
        /// <param name="fi">The fi.</param>
        /// <param name="ir">The ir.</param>
        static void FinalisteiPuntuEguneraketa(string fi, string ir)
        {
            for(int i=0;i<lp.Count;i++)
            {
                if (((lp[i].Finalista == fi) && (lp[i].Irabazlea == ir) || (lp[i].Finalista == ir) && (lp[i].Irabazlea == fi)))
                {
                    lp[i].Puntuak = lp[i].AsmatuBiFinalistak();
                }
            }
        }
        /// <summary>
        /// Goleatzaileens the puntu eguneraketa.
        /// </summary>
        /// <param name="gol">The gol.</param>
        static void GoleatzaileenPuntuEguneraketa(string gol)
        {
            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].Goleatzailea == gol)
                {
                    lp[i].Puntuak = lp[i].Goleko();
                }
            }
         }
        /// <summary>
        /// Fitxategias the irakurri.
        /// </summary>
        static void FitxategiaIrakurri()
        {           
            StreamReader sr = new StreamReader("porrak.txt");            
            String lerroa;
            lerroa = sr.ReadLine();                 
            while (lerroa != null)
            {               
                string[] zatitua = lerroa.Split("-");            
                Porra p = new Porra(zatitua[0], zatitua[1], zatitua[2], zatitua[3], int.Parse(zatitua[4]));
                lp.Add(p);
                lerroa = sr.ReadLine();
            }
            sr.Close();
           
        }
        /// <summary>
        /// Fitxategiras the puntuak.
        /// </summary>
        static void FitxategiraPuntuak()
        {
            StreamWriter sw = new StreamWriter("porrak.txt", false);          
            foreach (Porra p in lp)
            {

                sw.WriteLine(p.ToString());
            }           
           sw.Close();
        }
        /// <summary>
        /// Inprimatus the porrak.
        /// </summary>
        static void InprimatuPorrak()
        {
            Console.WriteLine("************************** EGUNGO PORRAREN EGOERA **********************************");
            foreach (Porra p in lp)
            {
                Console.WriteLine(p.Pantailaratu());
            }
            Console.WriteLine("");
        }
    }
}
