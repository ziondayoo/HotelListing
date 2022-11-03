﻿using HotelListingAPI.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name is too Long")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {   
        public int Id { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
    }

}
