using System.Collections.Generic;
using System.Threading.Tasks;
using ReservationSystem.Models;

namespace ReservationSystem.Repository
{
  public interface IReservationRepository
  {
    public Task<IList<Reservation>> GetAll();
    public Task<Reservation> GetById(int id);
    public Task<IList<Reservation>> GetByName(string name);

    public Task<Reservation> Create(Reservation res);
  }

}