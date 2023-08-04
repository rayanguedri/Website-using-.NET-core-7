﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.MVC.Data;

public partial class Client
{
    public int Id { get; set; }

    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;
[EmailAddress]
    public string Email { get; set; } = null!;
[Phone]
[MinLength(8)]
[MaxLength(8)]
    public string Phone { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public DateTime DateNaissance { get; set; }
}
