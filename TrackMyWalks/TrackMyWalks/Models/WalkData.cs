namespace TrackMyWalks.Models
{
    public class WalkData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distance { get; set; }
        public string Difficulty { get; set; }
        public string ImageUrl { get; set; }
    } 
}
 