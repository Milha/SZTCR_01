namespace SZTCR_01.Models.Domain
{
    public class Proizvodi
    {
        public Guid Id { get; set; }
        public string IdDobavljaca { get; set; }
        public string NazivProizvoda { get; set; }
        public int Kolicina { get; set; }

    }
}
