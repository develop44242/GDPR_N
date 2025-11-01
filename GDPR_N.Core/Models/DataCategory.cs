namespace GDPR_N.Core.Models;

public class DataCategory
{
    public Guid Id { get; set; }
    
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// E.g., "Customer Emails", "Employee Records"
    /// </summary>
    public string CategoryName { get; set; } = string.Empty;

    /// <summary>
    /// Legal basis for processing
    /// </summary>
    public string Purpose { get; set; } = string.Empty;
    
    public string StorageLocation { get; set; } = string.Empty;
    
    public int RetentionDays { get; set; }
}