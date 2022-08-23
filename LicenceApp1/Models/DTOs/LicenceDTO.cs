using LicenceApp1.Models.Entities;

namespace LicenceApp1.Models.DTOs
{
    public class LicenceDTO
    {
        public int IdLicence { get; set; }
        public string NameLicence { get; set; }
        public string TypeLicence { get; set; }
        public LicenceDTO() { }
        public LicenceDTO(Licence licence)
        {
            this.IdLicence = licence.IdLicence;
            this.NameLicence = licence.NameLicence;
            this.TypeLicence=licence.TypeLicence;
        }
    }
}
