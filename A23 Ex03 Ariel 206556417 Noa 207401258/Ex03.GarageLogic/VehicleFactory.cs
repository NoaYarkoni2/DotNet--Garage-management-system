using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleFactory
    {
        private List<Vehicles> m_Vehicles;
        public enum SupportedVehicles
        {
            Car,
            ElectricCar,    
            Motorcycle,
            ElectricMotorcycle,
            Truck
        }
        public VehicleFactory()
        {
            this.m_Vehicles = new List<Vehicles>();
        }


        //לא שלחתי
        public static SupportedVehicles GetVehicleTypeFromUser(int i_TypeInput)
        {          
            SupportedVehicles vehicleType;
            if (i_TypeInput == 1)
            {
                vehicleType = SupportedVehicles.Car;
            }
            else if (i_TypeInput == 2)
            {
                vehicleType = SupportedVehicles.ElectricCar;
            }
            else if (i_TypeInput == 3)
            {
                vehicleType = SupportedVehicles.Motorcycle;
            }
            else if (i_TypeInput == 4)
            {
                vehicleType = SupportedVehicles.ElectricMotorcycle;
            }
            else
            { vehicleType = SupportedVehicles.Truck; }
         
            return vehicleType;
        }




    }
}
