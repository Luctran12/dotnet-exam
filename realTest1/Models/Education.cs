﻿using System;
using System.Collections.Generic;

namespace realTest1.Models;

public partial class Education
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
