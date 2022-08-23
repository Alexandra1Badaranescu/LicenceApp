namespace LicenceApp1.Models.Entities
{
    public class Licence
    {
        public int IdLicence { get; set; }
        public string NameLicence { get; set; }
        public string TypeLicence { get; set; }
        public virtual Product Product { get; set; }

    }
}
