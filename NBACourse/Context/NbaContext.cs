using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NBACourse.Models;

namespace NBACourse.Context;

public partial class NbaContext : DbContext
{
    public NbaContext()
    {
    }

    public NbaContext(DbContextOptions<NbaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Conference> Conferences { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<League> Leagues { get; set; }

    public virtual DbSet<PersonalAward> PersonalAwards { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-LV6EI7UV;Database=NBA;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Conference>(entity =>
        {
            entity.HasKey(e => e.ConfId).HasName("PK__CONFEREN__8190AC98F75F9D09");

            entity.ToTable("CONFERENCE");

            entity.HasIndex(e => e.PlayerOfM, "UQ__CONFEREN__ED93420DDD75AF2C").IsUnique();

            entity.HasIndex(e => e.PlayerOfW, "UQ__CONFEREN__ED9342177856B74B").IsUnique();

            entity.Property(e => e.ConfId).HasColumnName("ConfID");
            entity.Property(e => e.ConfName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LeagueName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PlayerOfM)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlayerOfW)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.LeagueNameNavigation).WithMany(p => p.Conferences)
                .HasForeignKey(d => d.LeagueName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CONFERENC__Leagu__2A4B4B5E");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.DivisionId).HasName("PK__DIVISION__20EFC6883616C4D4");

            entity.ToTable("DIVISION");

            entity.HasIndex(e => e.MostAttackTeam, "UQ__DIVISION__A3EFB60FCA0785FF").IsUnique();

            entity.HasIndex(e => e.MostDefTeam, "UQ__DIVISION__AC418D37D7172B63").IsUnique();

            entity.Property(e => e.DivisionId).HasColumnName("DivisionID");
            entity.Property(e => e.ConfId).HasColumnName("ConfID");
            entity.Property(e => e.DivName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MostAttackTeam)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MostDefTeam)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Conf).WithMany(p => p.Divisions)
                .HasForeignKey(d => d.ConfId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DIVISION__ConfID__2F10007B");
        });

        modelBuilder.Entity<League>(entity =>
        {
            entity.HasKey(e => e.LeagueName).HasName("PK__LEAGUE__02D6A57369C4E1A7");

            entity.ToTable("LEAGUE");

            entity.HasIndex(e => e.Commissioner, "UQ__LEAGUE__6CBC60E2D004E977").IsUnique();

            entity.Property(e => e.LeagueName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Commissioner)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonalAward>(entity =>
        {
            entity.HasKey(e => e.AwardId).HasName("PK__PERSONAL__B08935DE0A1665CC");

            entity.ToTable("PERSONAL_AWARD");

            entity.HasIndex(e => new { e.AwardName, e.AwardYear }, "UQ__PERSONAL__A8B90B961E7D60D4").IsUnique();

            entity.Property(e => e.AwardId).HasColumnName("AwardID");
            entity.Property(e => e.AwardName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AwardYear)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

            entity.HasOne(d => d.Player).WithMany(p => p.PersonalAwards)
                .HasForeignKey(d => d.PlayerId)
                .HasConstraintName("FK__PERSONAL___Playe__44FF419A");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__PLAYER__4A4E74A8DF82B66F");

            entity.ToTable("PLAYER");

            entity.Property(e => e.PlayerId).HasColumnName("PlayerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GamePosition)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PlayerStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TeamId).HasColumnName("TeamID");

            entity.HasOne(d => d.Team).WithMany(p => p.Players)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK__PLAYER__TeamID__412EB0B6");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__TEAM__123AE7B940A803A3");

            entity.ToTable("TEAM");

            entity.HasIndex(e => e.City, "UQ__TEAM__F784DC2353C77D37").IsUnique();

            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.ChampionshipNum).HasColumnName("CHAMPIONSHIP_NUM");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.DivId).HasColumnName("DivID");
            entity.Property(e => e.TeamName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Div).WithMany(p => p.Teams)
                .HasForeignKey(d => d.DivId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TEAM__DivID__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
