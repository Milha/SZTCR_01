namespace SZTCR_01.Models.ViewModels
{
    public class EditSupplierRequest
    {
        public Guid Id { get; set; }
        public string? NazivDobavljaca { get; set; }
        public string? AdresaDobavljaca { get; set; }
        public string? EmailDobavljaca { get; set; }
    }
}
