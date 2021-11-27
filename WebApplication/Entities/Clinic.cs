using System;

namespace WebApplication.Entities
{
    public class Clinic : ISalveEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public void Parse<Clinic>(string line)
        {
            var values = line.Split(',');
            
            Id = Convert.ToInt32(values[0]);
            Name = values[1];
        }
    }
}