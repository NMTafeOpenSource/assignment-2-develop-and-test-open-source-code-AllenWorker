using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Service
    {
        // Constant to indicate that the vehicle needs to be serviced every 10,000km
        public static readonly int SERVICE_KILOMETER_LIMIT = 10000;

        private double lastServiceOdometerKm = 0;
        private int serviceCount = 0;
        private DateTime lastServiceDate = new DateTime();

        public Service( double lastServiceOdometerKm)
        {
            this.lastServiceOdometerKm = lastServiceOdometerKm;
        }

        /// <summary>
        /// The function recordService expects the total distance traveled by the car,
        /// saves it and increase serviceCount.
        /// </summary>
        /// <param name="distance"></param>
        public void RecordService(int distance)
        {
            lastServiceOdometerKm = distance; 
            serviceCount++;
            lastServiceDate = DateTime.Now.Date;
        }

        /// <summary>
        /// Determine the service is needed or not
        /// </summary>
        /// <returns>Return True if need service</returns>
        public bool ServiceRequired()
        {
            return (serviceCount < GetTotalScheduledServices());
        }

        /// <summary>
        /// Calculates the total services by dividing kilometers by
        /// #SERVICE_KILOMETER_LIMIT and floors the value.
        /// </summary>
        /// <returns>return the number of services needed per SERVICE_KILOMETER_LIMIT</returns>
        public int GetTotalScheduledServices()
        {
            return (int)Math.Floor(lastServiceOdometerKm / SERVICE_KILOMETER_LIMIT);
        }

        //  Gettter and Setter
        // return how many services the car has had

        public double LastServiceOdometerKm
        {
            get { return lastServiceOdometerKm; }
        }

        public int ServiceCount
        {
            get { return serviceCount; }
        }

        public DateTime LastServiceDate
        {
            get { return lastServiceDate; }
        }

    }
}
