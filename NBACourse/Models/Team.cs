using System;
using System.Collections.Generic;

namespace NBACourse.Models;

public partial class Team
{
    public int TeamId { get; set; }

    public string? TeamName { get; set; }

    public string City { get; set; } = null!;

    public int Games { get; set; }

    public int Points { get; set; }

    public int ConPoints { get; set; }

    public int WinsNumber { get; set; }

    public int LossesNumber { get; set; }

    public int PlaceInConf { get; set; }

    public int ChampionshipNum { get; set; }

    public int DivId { get; set; }

    public virtual Division Div { get; set; } = null!;

    public virtual ICollection<Player> Players { get; } = new List<Player>();
}
