﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.EntityFramework;

public class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }
    
    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}