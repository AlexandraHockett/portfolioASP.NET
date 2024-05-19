namespace portfolioASP.NET.Models
{
    public class CertificateModel
    {
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        public CertificateModel()
        {
            Link = string.Empty; // Inicialize com um valor padrão
            ImageUrl = string.Empty; // Inicialize com um valor padrão
            Title = string.Empty; // Inicialize com um valor padrão
        }
    }
}
