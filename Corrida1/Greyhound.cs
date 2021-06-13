using System;
using System.Drawing;
using System.Windows.Forms;

namespace Corrida1
{
    public class Greyhound
    {
        private Random _randomizer;
        private int _startingPosition;
        //private int _location;
        
        public PictureBox MyPictureBox { get; set; }
        public int Numero { get; set; }
        public int RacetrackLength { get; set; }

        public Greyhound()
        {
            MyPictureBox = null;
            //_location = 0;
        }

        public bool Run()
        {
            Point p = MyPictureBox.Location;
            _randomizer = new Random();

            p.X = p.X + _randomizer.Next(10);
            MyPictureBox.Location = p;

            if (p.X >= (RacetrackLength - this.MyPictureBox.Size.Width))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            Point p = this.MyPictureBox.Location;
            p.X = _startingPosition;
            this.MyPictureBox.Location = p;
        }
    }
}
