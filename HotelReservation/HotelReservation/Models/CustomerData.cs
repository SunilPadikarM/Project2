using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HotelReservation.Models
{
    public class CustomerData : DbContext
    {

        public DbSet<CustomerAccount> customeraccount { get; set; }

    
    }


    
}