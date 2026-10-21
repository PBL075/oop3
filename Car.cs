using System;

namespace cars
{
    class Car
    {
        public string model = "";
        public string culoare = "";
        private int cai ;
        public int Cai
        {
            get{
                Console.WriteLine(" Rezultat ");
                return this.cai;
            }
            set
            {
                if(cai > 1000)
                this.cai = 1000;
                else if (cai < 1)
                this.cai = 1;
            }    
        }
       public int Width{get ; set;}

        public Car(string model , string culoare , int cai)
        {
            this.model = model;
            this.culoare = culoare;
            this.cai = cai;
            
            
        }
        public void spawnCars()
        {
            Console.WriteLine("Model: " + this.model + "Culoarea " + this.culoare + "Cai " + this.cai);
        }
    }
}