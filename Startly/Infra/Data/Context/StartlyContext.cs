﻿using Microsoft.EntityFrameworkCore;
using Startly.Domain.Entities;
using Startly.Infra.Data.Configurations;

namespace Startly.Infra.Data.Context
{
    public class StartlyContext : DbContext
    {
        public DbSet<Startup> StartupSet { get; set; }
        public DbSet<StartupAtuacao> StartupAtuacaoSet { get; set; }
        public DbSet<StartupVideo> StartupVideoSet { get; set; }
        public DbSet<StartupContato> StartupContatoSet { get; set; }
        public DbSet<StartupImagem> StartupImagensSet { get; set; }
        public DbSet<Atuacao> AtuacaoSet { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StartupConfiguration());
            modelBuilder.ApplyConfiguration(new StartupImagensConfigurantion());
            modelBuilder.ApplyConfiguration(new StartupAtuacaoConfigurantion());
            modelBuilder.ApplyConfiguration(new StartupContatoConfigurantion());
            modelBuilder.ApplyConfiguration(new StartupVideoConfiguration());
            modelBuilder.ApplyConfiguration(new AtuacaoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string conexao
                = "server=localhost;database=startly;port=3306;uid=root";

            optionsBuilder
                .UseMySql(conexao, ServerVersion.AutoDetect(conexao));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
