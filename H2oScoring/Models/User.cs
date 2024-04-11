namespace H2oScoring.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserTypes UserType { get; set; }
        public Competitions Competition { get; set; }
        public Divisions Division { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }

    public enum UserTypes
    {
        Judge = 1, Admin = 2
    }

    public enum Divisions
    {
        HighSchool = 1, College = 2
    }
    
    public enum Competitions
    {
        Hackathon = 1, Multimedia = 2
    }
}
