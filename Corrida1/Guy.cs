using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corrida1
{
    public class Guy
    {
        private Bet _myBet;

        public string Name { get; set; } 
        public int Cash { get; set; }
        public RadioButton MyRadioButon { get; set; }
        public Label MyLabel { get; set; }

        public void UpdateLabels() 
        {
            if (this._myBet != null)
            {
                this.MyLabel.Text = this._myBet.GetDesciption();
            }
            else
            {
                this.MyLabel.Text = string.Format("{0} não fez nenhuma aposta.", this.Name);
            }
            this.MyRadioButon.Text = string.Format("{0} tem {1} reais", this.Name, this.Cash);

        }

        public void ClearBet()
        {
            if (this._myBet != null)
                this._myBet.Amount = 0;
        }

        public bool PlaceBet(int amount, int dog) // nova aposta
        {
            if (amount > this.Cash)
            {
                return false;
            }

            this._myBet = new Bet(); 
            this._myBet.Bettor = this;
            this._myBet.Dog = dog;
            this._myBet.Amount = amount;

            this.Cash = this.Cash - amount;

            return true;
        }

        public void Collect(int Winner)
        {
            if (this._myBet != null)
            {
                // Cobre minha aposta se eu ganhei
                this.Cash = this.Cash + this._myBet.PayOut(Winner);
            }
        }

    }
}
