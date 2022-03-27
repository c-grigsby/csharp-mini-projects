using ReservationSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReservationSystem.BusinessLogic
{
  public interface IReservationServices
  {
    public Task<IList<Reservation>> GetAll();
    public Task<Reservation> GetById(int id);
    public Task<Reservation> Create(Reservation res);
  }
}