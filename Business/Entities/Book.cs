using System;
using System.Collections.Generic;

namespace Business.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string? BookDescription { get; set; }

    public string? Author { get; set; }

    public DateTime ReleaseDate { get; set; }

    public bool? IsActived { get; set; }
}
