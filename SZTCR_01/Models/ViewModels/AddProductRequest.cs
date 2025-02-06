namespace SZTCR_01.Models.ViewModels
{
    public class AddProductRequest
    {
        public Guid IdDobavljaca { get; set; }
        public string NazivProizvoda { get; set; }
        public int Kolicina { get; set; }
    }
}
