using System.ComponentModel.DataAnnotations;

namespace ProductMasterService
{
    public class SubService
    {
        [Key]
        public int Id { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}