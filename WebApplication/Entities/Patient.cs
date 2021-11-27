using System;

namespace WebApplication.Entities
{
    public class Patient : ISalveEntity
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public void Parse<Patient>(string line)
        {
            var values = line.Split(',');
            
            Id = Convert.ToInt32(values[0]);
            ClinicId = Convert.ToInt32(values[1]);
            FirstName = values[2];
            LastName = values[3];
            DateOfBirth = Convert.ToDateTime(values[4]);
        }
    }
}