namespace AddressBook.Server.Modals
{

    public class Location
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class Name
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Picture
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }

    public class Result
    {
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Picture Picture { get; set; }
    }

    public class Root
    {
        public List<Result> Results { get; set; }
    }

}
