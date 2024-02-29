namespace Ct1450_Obdelnik.Model
{
    public class Obdelnik2
    {
        private int stranaA;
        private int stranaB;

        public int StranaA
        {
            get => stranaA;
            set
            {
                if (stranaA != value)
                {
                    if(value < 0)
                        stranaA = 0;
                    else
                        stranaA = value;
                }
                //Vypocet();
            }
        }
        public int StranaB { get => stranaB; set => stranaB = Math.Abs(value); }
        public int Obvod => 2 * (StranaA + StranaB);
        public int Obsah =>StranaA * StranaB;
        public double Uhlopricka => Math.Sqrt(Math.Pow(StranaA, 2) + StranaB * StranaB);

       
    }
}
