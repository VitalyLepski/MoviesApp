using System.ComponentModel.DataAnnotations;
using System;
using MoviesApp.Filters;

namespace MoviesApp.Services.Dto
{
    public class ActorDto
    {
        public int? Id { get; set; }
        [Required]
        [ActorsName]
        public string FirstName { get; set; }

        [Required, ActorsName] public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }

    public class ActorsNameAttribute : Attribute
    {
    }
}
