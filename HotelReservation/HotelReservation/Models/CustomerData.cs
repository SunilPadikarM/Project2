using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HotelReservation.Models
{
    public class CustomerData : DbContext
    {


        public DbSet<CustomerAccount> customeraccount { get; set; }

    
    }


    
}

        public CustomerData()
           : base("name=CustomerDetails1")
        {
        }
        public DbSet<CustomerAccount> customeraccount { get; set; }

        //public DbSet<Customer> Customers { get; set; }

        public DbSet<Reservation> reservations { get; set; }

        public DbSet<Room> room { get; set; }

    }
}
