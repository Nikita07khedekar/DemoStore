﻿using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Faq
{
    public long Id { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
