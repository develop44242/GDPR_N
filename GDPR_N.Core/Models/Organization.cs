using GDPR_N.Core.Models.Enumerations;

namespace GDPR_N.Core.Models;

public class Organization
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Industry { get; set; } = string.Empty;
    public SubscriptionTier SubscriptionTier { get; set; }
}