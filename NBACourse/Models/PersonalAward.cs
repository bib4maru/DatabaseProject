using System;
using System.Collections.Generic;

namespace NBACourse.Models;

public partial class PersonalAward
{
    public int AwardId { get; set; }

    public string AwardName { get; set; } = null!;

    public string AwardYear { get; set; } = null!;

    public int PlayerId { get; set; }

    public virtual Player Player { get; set; } = null!;
}
