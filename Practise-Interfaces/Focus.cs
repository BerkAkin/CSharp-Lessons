namespace Practise_Interfaces
{
    public class Focus : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}