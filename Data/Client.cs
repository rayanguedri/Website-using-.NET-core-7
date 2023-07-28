using System;
using System.Collections.Generic;

namespace SchoolManagement.MVC.Data;

public partial class Client
{
    public int Id { get; set; }

    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public DateTime DateNaissance { get; set; }
}
