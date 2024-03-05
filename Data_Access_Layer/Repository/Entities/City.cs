using System;
using System.Collections.Generic;

namespace Data_Access_Layer.Repository.Entities;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int UpdatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }
}
