using System;
using System.Collections.Generic;
using System.Text;

namespace CykelLib
{
    public class Cykel
    {
        private int _id;
        private string _farve;
        private int _pris;
        private int _gear;

        public Cykel(int id, string farve, int pris, int gear)
        {
            Id = id;
            Farve = farve;
            Pris = pris;
            Gear = gear;
        }

        public Cykel()
        {
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Farve
        {
            get => _farve;
            set
            {
                if (value.Length < 1) throw new ArgumentOutOfRangeException();
                _farve = value;
            }
        }

        public int Pris
        {
            get => _pris;
            set
            {
                if (value <= 0) throw new ArgumentException();
                _pris = value;
            } 
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if (value < 3 || value > 32) throw new ArgumentOutOfRangeException();
                _gear = value;
            } 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
