namespace Practise_Interfaces
{
    public class Civic : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}