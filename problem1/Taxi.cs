using System;

namespace Refactoring
{
    public class Taxi 
    {
        private bool airConditioned;
        private int totalKms;
        private bool peakTime;
    
        public Taxi(bool airConditioned, int totalKms, bool peakTime) {
            this.airConditioned = airConditioned;
            this.totalKms = totalKms;
            this.peakTime = peakTime;
        }
    
        public bool isAirConditioned() 
        {
            return airConditioned;
        }
    
        public int getTotalKms() 
        {
            return totalKms;
        }
    
        public bool isPeakTime()
        {
            return peakTime;
        }
	}
}