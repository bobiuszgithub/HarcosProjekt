namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapsztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev, int statuszSablon)
        {
            this.Nev = nev;
            szint = 1;
            tapsztalat = 0;
            if (statuszSablon == 1)
            {
                alapEletero = 15;
                alapSebzes = 3;
            }
            else if (statuszSablon == 2)
            {
                alapEletero = 12;
                alapSebzes = 4;
            }
            else if (statuszSablon == 3)
            {
                alapEletero = 8;
                alapSebzes = 5;
            }
            eletero = MaxEletero;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapsztalat
        {
            get => tapsztalat; set
            {

                if (this.tapsztalat == SzintLepeshez)
                {
                    this.szint++;
                    this.tapsztalat = SzintLepeshez - this.tapsztalat;
                    this.eletero = MaxEletero;
                }


            }
        }
        public int Eletero
        {
            get => eletero;
            set
            {
                eletero = value;
                if (this.eletero == 0)
                {
                    this.tapsztalat = 0;
                }
                if (this.eletero > MaxEletero)
                {
                    this.eletero = MaxEletero;
                }
            }

        }

        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }


        public int Sebzes { get => alapSebzes + szint; }

        public int SzintLepeshez { get => 10 + szint * 5; }

        public int MaxEletero { get => alapEletero + szint * 3; }




    }
}
