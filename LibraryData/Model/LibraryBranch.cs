﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class LibraryBranch
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Limit branch name to 30 characters")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual IEnumerable<Patron> Patrons {get; set;}
        public virtual IEnumerable<LibraryAsset> LibraryAssets { get; set; }

        public string ImageURL { get; set; }

    }
}
