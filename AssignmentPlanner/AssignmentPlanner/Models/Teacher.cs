using System;
using System.Collections.Generic;

namespace AssignmentPlanner.Models;

public partial class Teacher
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
