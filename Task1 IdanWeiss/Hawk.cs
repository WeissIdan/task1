namespace Task1_IdanWeiss
{
    internal class Hawk : Bird
    {
        protected double divingSpeed;
        public double getDivingSpeed()
        {
            return divingSpeed;
        }
        public void setDivingSpeed(double divingSpeed)
        {
            this.divingSpeed = divingSpeed;
        }
        //

        public Hawk(string name, int age, double caloriesPerMeal, int flightHeight, double wingspan, double divingSpeed)
        : base(name, age, isApexPredator: true, caloriesPerMeal, flightHeight, wingspan)
        {
            this.divingSpeed = divingSpeed;
        }
        public override string ToString()
        {
            return base.ToString() + $"\ndiving speed: {divingSpeed}";
        }
    }
}
