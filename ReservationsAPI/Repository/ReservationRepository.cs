using System.Collections.Generic;
using System;
using System.Threading.Tasks;

using ReservationSystem.Models;
namespace ReservationSystem.Repository
{
  public class ReservationRepository : IReservationRepository
  {
    IList<Reservation> reservations;

    public ReservationRepository()
    {
      reservations = new List<Reservation>(50);

      reservations.Add(new Reservation
      {
        Id = 1,
        CustomerName = "Dan",
        TimeRequested = new DateTime(2021, 1, 10, 18, 30, 00),
        Restaurant = "Sicilia's"
      });

      reservations.Add(new Reservation
      {
        Id = 2,
        CustomerName = "Elsa",
        TimeRequested = new DateTime(2021, 1, 10, 19, 30, 00),
        Restaurant = "Sicilia's"
      });
    }

    public async Task<IList<Reservation>> GetAll()
    {
      Task.Delay(3000).Wait();
      return reservations;
    }
    public async Task<Reservation> GetById(int id)
    {
      foreach (Reservation r in reservations)
      {
        if (r.Id == id)
        {
          return r;
        }
      }
      return null;
    }
    public async Task<IList<Reservation>> GetByName(string name)
    {
      Task.Delay(3000).Wait();
      List<Reservation> reservationsByName = new List<Reservation>();
      foreach (Reservation r in reservations)
      {
        if (r.CustomerName == name)
        {
          reservationsByName.Add(r);
        }
      }
      return reservationsByName;
    }
    public async Task<Reservation> Create(Reservation res)
    {
      reservations.Add(res);
      return res;
    }
  }
}