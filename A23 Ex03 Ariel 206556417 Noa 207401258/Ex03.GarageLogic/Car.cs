using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    class Car : Vehicles, IFuelVehicle, IElectric
    {
        private string m_Color;
        private int m_NumberOfDoors;
        private string m_Type;


        public enum PossibleColors
        {
            Red,
            Blue,
            White,
            Gray
        }
        private const int MinNumberOfDoors = 2;
        private const int MaxNumberOfDoors = 5;

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
            if ((Enum.TryParse(i_FuelTypes, out fuel) && Enum.IsDefined(typeof(PossibleFuelTypes), fuel))&& (i_AmountInLiters + CurrentFuelAmountInLiters <= MaximumFuelAmountInLiters))
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



    }
}
