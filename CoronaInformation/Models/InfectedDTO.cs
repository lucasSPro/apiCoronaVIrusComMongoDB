using System;
using MongoDB.Bson;
namespace CoronaInformation.Models
{
    public class InfectedDTO
    {
        public ObjectId Id { get; set; }
        public DateTime DateOfBirth{get; set;}
        public string Gender{get; set;}
        public double Latitude {get; set;}
        public double Longitude {get; set;}

        public InfectedDTO (){

        }
        public InfectedDTO ( ObjectId id, DateTime dateOfBirth, string gender, double latitude, double longitude ){
           Id = id;
           DateOfBirth = dateOfBirth;
           Gender = gender;
           Latitude =  latitude;
           Longitude =  longitude; 
        }
          public InfectedDTO (DateTime dateOfBirth, string gender, double latitude, double longitude ){
           DateOfBirth = dateOfBirth;
           Gender = gender;
           Latitude =  latitude;
           Longitude =  longitude; 
        }
    }
}
