namespace Years.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Year { get; set; }
        public bool Result { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
