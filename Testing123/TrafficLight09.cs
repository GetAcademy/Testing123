using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing123
{
    class TrafficLight09
    {
        public bool IsRedOn { get; private set; }
        public bool IsYellowOn { get; private set; }
        public bool IsGreenOn { get; private set; }

        public TrafficLight09()
        {
            IsRedOn = true;
        }

        public void NextPhase()
        {
            if (IsRedOn && !IsYellowOn)
            {
                IsYellowOn = true;
            }
            else if (IsRedOn && IsYellowOn)
            {
                IsGreenOn = true;
                IsRedOn = false;
                IsYellowOn = false;
            }
            else if (IsGreenOn)
            {
                IsGreenOn = false;
                IsYellowOn = true;
            }
            else
            {
                IsRedOn = true;
                IsYellowOn = false;
            }
        }
    }
}
