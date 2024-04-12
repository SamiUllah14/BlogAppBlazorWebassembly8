namespace BlogApp.Server.Models
{
    // Card.cs
    public class Card
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty ;

        public string Description { get; set; } = string.Empty;

        public string ReadMoreUrl { get; set; } = string.Empty;

        public CardDetail cardDetail { get; set; }
    }

}
