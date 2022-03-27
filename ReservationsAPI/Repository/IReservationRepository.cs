using System.Collections.Generic;
using System.Threading.Tasks;
using ReservationSystem.Models;

namespace ReservationSystem.Repository
{
    public interface IReservationRepository
    {
         public  Task<IList<Reservation>> GetAll() ;
          public  Task<Reservation> GetById(int id);
           public  Task<Reservation> Create(Reservation res);
    }
    
}