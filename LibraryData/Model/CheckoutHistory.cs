using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class CheckoutHistory
    {
        public int Id { get; set; }
        public LibraryAsset LibraryAsset { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime? CheckIn { get; set; }


    }
}
