using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public interface IFuelVehicle
    {
        string FuelType { get; set; }
        float CurrentFuelAmountInLiters { get; set; }
        float MaximumFuelAmountInLiters { get; set; }
        void Refuel(float i_AmountInLiters, string i_FuelTypes);
       
    }
}
