namespace Corrida1
{
    public class Bet
    {
        public int Amount { get; set; }//resultar o valor da aposta
        public int Dog { get; set; }
        public Guy Bettor { get; set; } //apostador

    public string GetDesciption()
        {
            if (Amount == 0)
            {
                return string.Format("{0} não apostou", Bettor.Name);
            }

            return string.Format("{0} apostou {1} no cachorro {2}",
                                Bettor.Name,
                                 Amount,
                                 Dog);
        }

        public int PayOut(int winner)
        {
            if (winner == Dog)
            {
                return Amount * 2;
            }
            else
            {
                return 0;
            }

        }
    }
}
