﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmprestimosLivros.API.Models;

public partial class ControleEmprestimoLivroContext : DbContext
{
    public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<Livro> Livro { get; set; }

    public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
{
    entity.Property(e => e.Id).ValueGeneratedNever();

    entity.HasOne(d => d.LceIdClienteNavigation).WithMany(p => p.LivroClienteEmprestimo)
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Livro_Cliente_Emprestimo_Cliente");

    entity.HasOne(d => d.LceIdLivroNavigation).WithMany(p => p.LivroClienteEmprestimo)
        .OnDelete(DeleteBehavior.ClientSetNull)
        .HasConstraintName("FK_Livro_Cliente_Emprestimo_Livro");
});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}