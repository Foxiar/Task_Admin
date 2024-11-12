namespace Kalendar
{
    internal class Udalost
    {
        public DateOnly DatumUdalosti { get; set; }
        public string NadpisUdalosti { get; set; }
        public string ObsahUdalosti { get; set; }
        public int IdUdalosti { get; set; }

        public static int Counter = 1;


        public Udalost(DateOnly datumUdalosti, string nadpisUdalosti, string obsahUdalosti = "")
        {
            DatumUdalosti = datumUdalosti;
            NadpisUdalosti = nadpisUdalosti;
            ObsahUdalosti = obsahUdalosti;
            IdUdalosti = Counter;
            Counter++;
        }

    }
}
