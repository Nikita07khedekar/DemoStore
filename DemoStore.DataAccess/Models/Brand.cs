﻿using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Brand
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
