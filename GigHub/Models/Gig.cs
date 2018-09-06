using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        [Required] // we added required to make sure that the foreign key property is set not the artist navigation property 
        public string ArtistId { get; set; } // the reason it's string cause the key at ApplicationUser is a string 

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; } // the reason it's byte cause Genre id is byte not int  
    }

}