using System.Collections.Generic;
using System.Threading.Tasks;
using ReservationSystem.Repository;
using ReservationSystem.Models;

namespace ReservationSystem.BusinessLogic
{
  public class ReservationServices : IReservationServices
  {
    private IReservationRepository _repo;

    public ReservationServices(IReservationRepository repo)
    {
      _repo = repo;
    }

    public async Task<IList<Reservation>> GetAll()
    {
      return await _repo.GetAll();
    }

    public async Task<Reservation> GetById(int id)
    {
      return await _repo.GetById(id);
    }

    public async Task<Reservation> Create(Reservation res)
    {
      return await _repo.Create(res);
    }
  }
}

