namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public required byte[] PassWordHash { get; set; }

        public required byte[] PassWordSalt { get; set; }
    }
}
