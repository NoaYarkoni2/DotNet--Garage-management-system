using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    class CarInTheGarage : Vehicles
    {
        public enum Situation
        {
            Repaired,
            Fixed,
            Paid
        }

        private string m_OwnerName;
        private string m_OwnerPhone;
        private Situation m_MonditionOfVehicleInTheGarage;
        public CarInTheGarage(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy)
            : base (i_OwnerName, i_OwnerPhone, i_MonditionOfVehicleInTheGarage)
        {
            this.i_MonditionOfVehicleInTheGarage = Situation.Repaired;
        }

        

    }
}
