namespace Practise_Interfaces
{
    public class Corolla : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}