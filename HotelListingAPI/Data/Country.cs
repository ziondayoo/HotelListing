﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Data
{
    public class Country
    {
        [Key]
        public int  Id { get; set; }
        public string Name { get; set; }
        public string  ShortName { get; set; }
        public virtual IList<Hotel> Hotels { get; set; }
    }
}
