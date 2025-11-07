using GDPR_N.Core.Models.Enumerations;

namespace GDPR_N.Core.Models;

public class DataSubjectRequest
{
    public Guid Id { get; set; }
    public Guid OrganizationId { get; set; }
    
    /// <summary>
    /// Access, Deletion, or Portability
    /// </summary>
    public RequestType Type { get; set; }
    public string SubjectEmail { get; set; }
    public RequestStatus Status { get; set; }
    public DateTime RequestDate { get; set; }
    public DateTime DueDate { get; set; } // Auto-calculated (30 days)
    public string Notes { get; set; }
}