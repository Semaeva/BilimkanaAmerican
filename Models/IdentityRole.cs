using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BilimkanaAmerican.Models
{
    public class IdentityRole
    {
        public virtual Key Id { get; set; }
        public virtual string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public virtual string? ConcurrencyStamp { get; set; }
    }
}
