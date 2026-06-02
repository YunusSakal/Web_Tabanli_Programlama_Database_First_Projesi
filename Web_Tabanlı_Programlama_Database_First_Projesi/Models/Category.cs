using System;
using System.Collections.Generic;

namespace Web_Tabanlı_Programlama_Database_First_Projesi.Models;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }
}
