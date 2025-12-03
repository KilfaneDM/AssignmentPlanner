using System;
using System.Collections.Generic;

namespace AssignmentPlanner.Models;

public partial class Login
{
    public int? Nbccid { get; set; }

    public string? Password { get; set; }

    public string? UserType { get; set; }
}
