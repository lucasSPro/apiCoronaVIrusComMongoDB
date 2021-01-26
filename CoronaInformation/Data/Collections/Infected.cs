using System;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Bson;

namespace CoronaInformation.Data.Collections
{
    public class Infected
    {
        public ObjectId Id { get; set; }
        public Infected (DateTime dateOfBirth, string gender, double latitude, double longitude){
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Localization = new GeoJson2DGeographicCoordinates(latitude, longitude);
        }
        public Infected (ObjectId id,DateTime dateOfBirth, string gender, double latitude, double longitude){
            this.Id = id;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Localization = new GeoJson2DGeographicCoordinates(latitude, longitude);
        }
        public DateTime DateOfBirth {get; set;}
        public string Gender {get; set;}
        public GeoJson2DGeographicCoordinates Localization {get; set;}
    }
}