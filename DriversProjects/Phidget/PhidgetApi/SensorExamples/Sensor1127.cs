using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;


namespace Phidget21Api
{
    public partial class Sensor1127 : BaseSensor
    {

        public override double changeDisplay(int val, out string str)
        {
            str = val.ToString() + " lx";
            return (double)val;
        }

    }
}
