using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class Bike
    {
        public string BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {
            BikeId = bikeId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
        }private decimal RentalAmount { get;set; }

        public override string ToString()
        {
            return $"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}";
        }
    }
    
}
