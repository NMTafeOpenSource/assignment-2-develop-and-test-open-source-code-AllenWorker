using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class Journey
    {
        public double Kilometers { get; set; }

        /**
	     * Class constructor
	     */
        public Journey()
        {
            Kilometers = 0;
        }

        /** 
	     * Appends the distance parameter to {@link #kilometers}
	     * @param kilometers the distance traveled 
	     */
        public void AddKilometers(double Kilometers)
        {
            this.Kilometers += Kilometers;
        }




    }
}
