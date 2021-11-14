using System.ComponentModel.DataAnnotations;

namespace GraphQLNetExample.Notes;

public class Note
{
    public Guid Id { get; set; }
    [Required]
    public string Message { get; set; }
}