using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicles, IFuelVehicle, IElectric
    {
        private string m_LicenseType;
        private int m_EngineVolumeInCC;
        private string m_Type;

        public enum PossibleLicenseTypes
        {
            A,
            AA,
            A1,
            B
        }

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

        //interface IElectric
        public float BatteryTimeRemainingInHours { get; set; }
        public float MaximumBatteryTimeInHours { get; set; }
        public void BatteryCharging(int i_NumberOfHoursToAdd)
        {
            if ((BatteryTimeRemainingInHours + i_NumberOfHoursToAdd) <= MaximumBatteryTimeInHours)
            {
                BatteryTimeRemainingInHours += i_NumberOfHoursToAdd;
            }
        }

        public Motorcycle(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy, string i_LicenseType, int i_EngineVolumeInCC, string i_Type)
        : base(i_ModelName, i_LicenseNumber, i_PercentageRemainingEnergy)
        {
            this.m_LicenseType = i_LicenseType;
            this.m_EngineVolumeInCC = i_EngineVolumeInCC;
            this.m_Type = i_Type;
        }




    }

}
