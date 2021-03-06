namespace AMExpenses.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal CreditOnAccountAmount { get; set; }
    }
}