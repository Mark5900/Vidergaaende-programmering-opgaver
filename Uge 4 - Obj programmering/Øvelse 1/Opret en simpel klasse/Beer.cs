using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opret_en_simpel_klasse
{
    internal class Beer
    {
        private string name;
        private int size;
        private int prize;
        private bool Alcohol;
        private double Procent;

        public Beer(string name, int size, int prize, double alcoholProcent)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name is null or empty");
            if (size < 0)
                throw new ArgumentException("Size is less than 0");
            if (prize < 0)
                throw new ArgumentException("Prize is less than 0");
            if (alcoholProcent < 0)
                throw new ArgumentException("Alcohol procent is less than 0");
            if (alcoholProcent > 100)
                throw new ArgumentException("Alcohol procent is more than 100");

            this.name = name;
            this.size = size;
            this.prize = prize;
            this.Procent = alcoholProcent;

            if (alcoholProcent > 0) { 
                this.Alcohol = true;
            }
            else
            {
                this.Alcohol = false;
            }

        }

        public string ToString()
        {
            return $"{name},{size},{prize}";
        }

        public int GetPrice()
        {
            return prize;
        }
    }
}
