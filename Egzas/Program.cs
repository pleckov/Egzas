using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzas
{

    class Darbuotojas
    {
        private string Vardas;
        private string Pavarde;
        private string Pareigos;
        private string VairuojamasAutomobilis;

        public Darbuotojas(string vardas, string pavarde, string pareigos, string vairuojamasauto)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pareigos = pareigos;
            VairuojamasAutomobilis = vairuojamasauto;
        }
    }

    class Automobilis
    {
        private string ValstNumeris;
        private string Marke;
        private string Modelis;
        private string PagaminimoMetai;
        private double DarbinisTuris;
        private string KuroTipas;
        private double KuroNorma;
        private int AutomobilioRida;
        private string Vairuotojas;

        public Automobilis(string valstnumeris, string marke, string modelis, string pagmetai, double darbturis, string kurotipas, double kuronorma, int autorida, string vadila)
        {
            ValstNumeris = valstnumeris;
            Marke = marke;
            Modelis = modelis;
            PagaminimoMetai = pagmetai;
            DarbinisTuris = darbturis;
            KuroTipas = kurotipas;
            KuroNorma = kuronorma;
            AutomobilioRida = autorida;
            Vairuotojas = vadila;
        }
    }

    class KurasPerMen
    {
        private int SpidPradzia;
        private int SpidPabaiga;
        private double PiltaKuro;
        private string KadaPiltasKuras;

        public KurasPerMen(int spidpradzia, int spidpabaiga, double piltakuro, string kadapiltaskuras)
        {
            SpidPradzia = spidpradzia;
            SpidPabaiga = spidpabaiga;
            PiltaKuro = piltakuro;
            KadaPiltasKuras = kadapiltaskuras;
        }
    }

    class Kelione
    {
        private string KelionesPradzia;
        private string KelionesPabaiga;
        private string KelionesData;
        private int NuvaziuotaKm;

        public Kelione(string taskasa, string taskasb, string kelionesdata, int nuvaziuotakm)
        {
            KelionesPradzia = taskasa;
            KelionesPabaiga = taskasb;
            KelionesData = kelionesdata;
            NuvaziuotaKm = nuvaziuotakm;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
