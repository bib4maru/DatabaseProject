using System;
using System.Collections.Generic;

namespace NBACourse.Models;

public partial class Division
{
    public int DivisionId { get; set; }

    public string DivName { get; set; } = null!;

    public string MostDefTeam { get; set; } = null!;

    public string MostAttackTeam { get; set; } = null!;

    public int ConfId { get; set; }

    public virtual Conference Conf { get; set; } = null!;

    public virtual ICollection<Team> Teams { get; } = new List<Team>();
}
