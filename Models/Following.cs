namespace IntrogamiAPI.Models
{
    public class Following
    {
        public int EmailId { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
