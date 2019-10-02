using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class Video:LibraryAsset
    {
        [Required]
        public string Director { get; set; }

    }
}
