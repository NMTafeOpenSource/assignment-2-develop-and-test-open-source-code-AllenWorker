using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Journey
    {
        public double Kilometers { get; set; }

        /// <summary>
        /// Class Constructor
        /// </summary>
        public Journey()
        {
            Kilometers = 0;
        }



        /// <summary>
        /// Appends the distance parameter to Kilometers
        /// </summary>
        /// <param name="Kilometers"></param>
        public void AddKilometers(double Kilometers)
        {
            this.Kilometers += Kilometers;
        }




    }
}
