using System;
using System.Collections.Generic;

namespace NBACourse.Models;

public partial class League
{
    public string LeagueName { get; set; } = null!;

    public string Commissioner { get; set; } = null!;

    public int CurrWeek { get; set; }

    public int СurrMonth { get; set; }

    public virtual ICollection<Conference> Conferences { get; } = new List<Conference>();
}
