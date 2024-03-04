using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CarRentalAgency.Models{
    public class Transaction
    {
        public int TransactionId {get;set;}
        public int ClientId {get;set;}
        public int CarId {get;set;}

        public Client? Client {get; set;}
        public Car? Car {get; set;}
        

    }

}