namespace Yoo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        //foreign key for Flower
        public int FlowerId { get; set; }
        public Flower Flower { get; set; }
    }
}
