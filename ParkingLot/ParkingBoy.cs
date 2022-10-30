﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingBoy
    {
        private ParkingLots parkingLot;

        public ParkingBoy(ParkingLots parkingLots)
        {
            this.parkingLot = parkingLots;
        }

        public Car FetchCar(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException("Please provide your parking ticket.");
            }

            return this.parkingLot.GetCar(ticket);
        }

        public Ticket ParkingCar(Car car)
        {
            return this.parkingLot.StorageCar(car);
        }
    }
}