namespace Sample1.Models
{
    public class AuditData
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsActive { get; set; } = false;
        public string CreatedBy { get; set; } = "SYSTEM";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
