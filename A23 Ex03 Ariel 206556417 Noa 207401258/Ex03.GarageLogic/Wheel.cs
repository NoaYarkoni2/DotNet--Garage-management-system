using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Wheel 
    {
        private string m_ManufacturerName; //שם יצרן
        private float m_CurrentAirPressure; //לחץ אוויר נוכחי
        private float m_MaximumAirPressureDetermined; //לחץ אוויר מקסימאלי שקבע היצרן
        public void InflationAction(float i_AirPressureToAdd)
        {
            if ((m_CurrentAirPressure + i_AirPressureToAdd) < m_MaximumAirPressureDetermined)
            {
                m_CurrentAirPressure += i_AirPressureToAdd;
            }
        }

        public Wheel(string i_ManufacturerName, float i_MaximumAirPressureDetermined, float i_CurrentAirPressure)
        {
            this.m_ManufacturerName = i_ManufacturerName;
            this.m_MaximumAirPressureDetermined = i_MaximumAirPressureDetermined;
            this.m_CurrentAirPressure = i_CurrentAirPressure;
        }

        public string ManufacturerName
        {
            get { return m_ManufacturerName; }
            set { m_ManufacturerName = value; }
        }
        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set { m_CurrentAirPressure = value; }
        }
        public float MaximumAirPressureDetermined
        {
            get { return m_MaximumAirPressureDetermined; }
            set { m_MaximumAirPressureDetermined = value; }
        }

        //שאלה 4
        public void InflateWheelToLimit()
        {
            float airPressureToAdd = this.MaximumAirPressureDetermined - this.CurrentAirPressure;
            this.InflationAction(airPressureToAdd);
        }
    }
}
