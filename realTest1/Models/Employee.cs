using System;
using System.Collections.Generic;

namespace realTest1.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public DateTime? StartingDate { get; set; }

    public int? EducationId { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Education? Education { get; set; }
}
