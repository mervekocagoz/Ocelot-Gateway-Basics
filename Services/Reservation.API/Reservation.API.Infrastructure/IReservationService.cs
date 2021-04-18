using Reservation.API.Models;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        public void Create(ReservationDTO Reservation);

        public ReservationDTO GetReservation();

        public ReservationDTO GetReservationById(int Id);
    }
}