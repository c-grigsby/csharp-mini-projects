using System;
namespace ReservationSystem.Models

{
    public class Reservation {
        public int Id {get;set;}
        public string CustomerName {get;set;}
        public DateTime TimeRequested {get;set;}
        public string Restaurant {get;set;}
    }
    
}