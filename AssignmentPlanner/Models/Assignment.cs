using System;
using System.Collections.Generic;

namespace AssignmentPlanner.Models;

public partial class Assignment
{
    public int Id { get; set; }

    public string? AssignName { get; set; }

    public DateOnly? DueDate { get; set; }

    public string? AssignDesc { get; set; }
}
