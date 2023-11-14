using System;
using System.Collections.Generic;

namespace Business.Entities;

public partial class UserAccount
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string? UserAddress { get; set; }

    public string? UserPhone { get; set; }

    public int? RoleId { get; set; }
}
