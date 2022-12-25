using System;
using System.Collections.Generic;

namespace NBACourse.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int Games { get; set; }

    public int Points { get; set; }

    public int ContractDuration { get; set; }

    public string PlayerStatus { get; set; } = null!;

    public string GamePosition { get; set; } = null!;

    public int TeamId { get; set; }

    public virtual ICollection<PersonalAward> PersonalAwards { get; } = new List<PersonalAward>();

    public virtual Team Team { get; set; } = null!;
}
