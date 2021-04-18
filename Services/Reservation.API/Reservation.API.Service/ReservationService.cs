using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Service
{
    public class ReservationService : IReservationService
    {
        public void Create(ReservationDTO Reservation)
        {
            // TODO Creation Stuff
        }

        public ReservationDTO GetReservation()
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                BkgNumber = (new Random()).Next(100),
                BkgDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                //OwnerContact = Guid.NewGuid(),
                Amount = (new Random()).Next(1000, 10000)
            };
        }

        public ReservationDTO GetReservationById(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                BkgNumber = BkgNumber,
                BkgDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                //OwnerContact = Guid.NewGuid(),
                Amount = (new Random()).Next(1000, 10000)
            };
        }
    }
}