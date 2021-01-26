using System;
using CoronaInformation.Data.Collections;
using CoronaInformation.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;

namespace CoronaInformation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectedController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infected> _infectedsCollection;
        public InfectedController(Data.MongoDB mongoDB)
        {
            _mongoDB =  mongoDB;
            _infectedsCollection = _mongoDB.DB.GetCollection<Infected>(typeof(Infected).Name.ToLower());
        } 
        [HttpPost]
        public ActionResult SaveInfected([FromBody] InfectedDTO dto)
        {
            var infected = new Infected(dto.DateOfBirth, dto.Gender, dto.Latitude, dto.Longitude);
            _infectedsCollection.InsertOne(infected);
            return StatusCode(201,"Infectado adicionado com sucesso.");
        }
        [HttpGet]
        public ActionResult GetInfeted()
        {
            var infeteds = _infectedsCollection.Find(p => p.Id != null).ToList();

            return Ok(infeteds);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateInfected (string id,[FromBody] InfectedDTO dto)
        {
           var idBoson =  new ObjectId(id);
           var infected = new Infected(idBoson ,dto.DateOfBirth, dto.Gender, dto.Latitude, dto.Longitude);
           var filter = Builders<Infected>.Filter.Eq(p => p.Id, idBoson);
           var result = _infectedsCollection.ReplaceOne(filter, infected);

           return Ok(infected);
        }
        [HttpDelete("{dateOfBirth}")]
        public ActionResult Delete(string dateOfBirth)
        {
            _infectedsCollection.DeleteOne(Builders<Infected>.Filter.Where(p => p.DateOfBirth == Convert.ToDateTime(dateOfBirth)));
            return Ok("Registro removido");
        }
    }
}