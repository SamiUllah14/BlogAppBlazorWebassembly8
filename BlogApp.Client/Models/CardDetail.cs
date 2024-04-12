namespace BlogApp.Client.Models
{
    public class CardDetail
    {
        public int Id { get; set; }


        public string MoreDescription { get; set; } = string.Empty;

        public int CardId { get; set; }
        public Card card { get; set; }




    }
}
