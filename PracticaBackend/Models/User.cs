﻿using System;
using System.Collections.Generic;

namespace PracticaBackend.Models;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Pass { get; set; }

    public string? Email { get; set; }
}
