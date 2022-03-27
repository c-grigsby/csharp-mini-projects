using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReservationSystem.BusinessLogic;
using ReservationSystem.Models;

namespace ReservationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {
       private IReservationServices _services;

        public ReservationsController(IReservationServices service)
        {
            _services = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IList<Reservation> list =  await _services.GetAll();
            if(list!=null) return Ok(list);
            else return BadRequest();
        }
        [HttpGet("{id}", Name="GetReservationById")]
        public async Task<IActionResult> GetById(int id)
        {
            Reservation res = await _services.GetById(id);
            if(res!=null) return Ok(res);
            else return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Reservation resIn)
        {
            Reservation res =  await _services.Create(resIn);
            if(res!=null) return CreatedAtRoute("GetReservationById",new {Id=res.Id},res);
            else return BadRequest();
        }
    }
}
