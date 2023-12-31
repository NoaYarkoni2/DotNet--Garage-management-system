using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.GarageLogic
{
    public interface IElectric
    {
        float BatteryTimeRemainingInHours { get; set; }
        float MaximumBatteryTimeInHours { get; set; }
        void BatteryCharging(int i_NumberOfHoursToAdd);
    }

}
