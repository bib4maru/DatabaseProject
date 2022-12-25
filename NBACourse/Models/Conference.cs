using System;
using System.Collections.Generic;

namespace NBACourse.Models;

public partial class Conference
{
    public int ConfId { get; set; }

    public string ConfName { get; set; } = null!;

    public string PlayerOfW { get; set; } = null!;

    public string PlayerOfM { get; set; } = null!;

    public string LeagueName { get; set; } = null!;

    public virtual ICollection<Division> Divisions { get; } = new List<Division>();

    public virtual League LeagueNameNavigation { get; set; } = null!;
}
