namespace CarRentalAgency.Models{
    public class Client
    {
        public int ClientId {get;set;}
        public string firstName {get;set;}
        public string secondName {get;set;}

        public string Email {get;set;}

        public string mobileNumber{get;set;}


        public ICollection<Transaction>? Transactions {get;set;}



    }

}