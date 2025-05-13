using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interface_notes.Entities;

namespace interface_notes.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;


        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayments = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayments = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayments = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayments);

            carRental.Invoice = new Invoice(basicPayments, tax);

        }
    }
}
