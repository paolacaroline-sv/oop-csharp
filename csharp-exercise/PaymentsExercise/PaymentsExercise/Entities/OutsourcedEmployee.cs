namespace PaymentsExercise.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)    
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double charge = 1.1 * AdditionalCharge; //110%
            return base.Payment() + charge;
        }
     }
}
