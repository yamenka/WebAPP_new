namespace CarRentalAgency.Models{
    public class Car{
        public int CarId {get;set;}
        public string Model {get;set;}
        public string Make {get;set;}

        public double MakeYear {get; set;}

        public double HorsePower {get; set;}
        public string Color {get; set;}


        public ICollection<Transaction>? Transactions {get;set;}


    }

}