using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    class Truck : Vehicles, IFuelVehicle
    {
        private bool m_IsTransportingHazardousMaterials; //האם מוביל חומרים מסוכנים
        private float m_CargoVolume; //נפח מטען

        //interface IFuelVehicle
        public string FuelType { get; set; }
        public float CurrentFuelAmountInLiters { get; set; }
        public float MaximumFuelAmountInLiters { get; set; }
        public enum PossibleFuelTypes
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }
        public void Refuel(float i_AmountInLiters, string i_FuelTypes)
        {
            PossibleFuelTypes fuel;
            if ((Enum.TryParse(i_FuelTypes, out fuel) && Enum.IsDefined(typeof(PossibleFuelTypes), fuel)) && (i_AmountInLiters + CurrentFuelAmountInLiters <= MaximumFuelAmountInLiters))
            {
                CurrentFuelAmountInLiters += i_AmountInLiters;
            }
        }

        public Truck(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, bool i_IsTransportingHazardousMaterials, float i_CargoVolume)
            : base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy)
        {
            this.m_IsTransportingHazardousMaterials = i_IsTransportingHazardousMaterials;
            this.m_CargoVolume = i_CargoVolume;
        }

    }
}
