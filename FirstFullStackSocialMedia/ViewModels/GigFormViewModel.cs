using FirstFullStackSocialMedia.Models;

namespace FirstFullStackSocialMedia.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public System.Collections.Generic.IEnumerable<Genre> Genres { get; set; }
    }
}