using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    class Vehicles
    {
        private string m_ModelName;
        private string m_LicenseNumber;
        private float m_PercentageRemainingEnergy;
        private List<Wheel> m_CollectionOfWheels;


        public Vehicles(string i_ModelName, string i_LicenseNumber, float i_PercentageRemainingEnergy)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_PercentageRemainingEnergy = i_PercentageRemainingEnergy;
            this.m_CollectionOfWheels = new List<Wheel>();
        }

    }

}
