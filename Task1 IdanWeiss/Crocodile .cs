using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IdanWeiss
{
    internal class Crocodile :Reptile
    {
        protected bool didGoToHisYearlyDentistAppointment;
        public bool getYearlyDentist()
        {
            return didGoToHisYearlyDentistAppointment;
        }
        public void setYearlyDentist(bool didGoToHisYearlyDentistAppointment)
        {
            this.didGoToHisYearlyDentistAppointment = didGoToHisYearlyDentistAppointment;
        }
        //
        public Crocodile(string name, int age, bool isApexPredator, double caloriesPerMeal, double tailLen,bool didGoToHisYearlyDentistAppointment)
            : base(name, age, isApexPredator, caloriesPerMeal, tailLen)
        {
            this.didGoToHisYearlyDentistAppointment = didGoToHisYearlyDentistAppointment;
        }
        public override string ToString()
        {
            return base.ToString() + $"\ndid he go to the dentist this yaer?: {didGoToHisYearlyDentistAppointment}";
        }
    }
}
