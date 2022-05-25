using System;

namespace Lab_4
{
    public class Firm
    {
        private string name;
        private static Tariff tariff= new Tariff();
        private static Firm firmInstance;
       

        private Firm() { }

        public string Name
        {
            get { return firmInstance.name; }
            private set { firmInstance.name = value; }
        }

        public int revenue ()
        {
            if(tariff!= null)
            {
                return tariff.TariffSize * tariff.Mass;
            }
            else
            {
                return 0;
            }
        }

        public static Firm getInstance(string name)
        {
            if (firmInstance == null)
            {
                firmInstance = new Firm();
                firmInstance.name = name;
            }
            return firmInstance;
        }

    }

    public class Tariff
    {
        private int mass;
        private int tariffSize;
        
        public int Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public int TariffSize
        {
            get { return tariffSize; }
            set { tariffSize = value; }
        }

        public void ChangeTariffSizeUp(int amount)
        {
            if (amount > 0)
            {
                tariffSize += amount;
            }          
        }
        public void ChangeTariffSizeDown(int amount)
        {
            if (tariffSize-amount>=0)
            {
                tariffSize -= amount;
            }
            else
            {
                tariffSize = 0;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
