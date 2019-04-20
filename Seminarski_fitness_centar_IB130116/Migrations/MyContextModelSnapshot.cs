﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seminarski_fitness_centar_IB130116.DB;

namespace Seminarski_fitness_centar_IB130116.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("MasterAdmin");

                    b.Property<int>("UserId");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Admini");
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.DolazakOdlazak", b =>
                {
                    b.Property<int>("DolazakOdlazakId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<DateTime>("VrijemeDolaska");

                    b.Property<DateTime>("VrijemeOdlaska");

                    b.HasKey("DolazakOdlazakId");

                    b.HasIndex("UserId");

                    b.ToTable("DolasciOdlasci");
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.Obavjestenje", b =>
                {
                    b.Property<int>("ObavjestenjeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naslov")
                        .IsRequired();

                    b.Property<string>("Tekst")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<DateTime>("Vrijeme");

                    b.HasKey("ObavjestenjeId");

                    b.HasIndex("UserId");

                    b.ToTable("Obavjestenja");
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.HasKey("ZaposlenikId");

                    b.HasIndex("UserId");

                    b.ToTable("Zaposlenici");
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.Admin", b =>
                {
                    b.HasOne("Seminarski_fitness_centar_IB130116.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.DolazakOdlazak", b =>
                {
                    b.HasOne("Seminarski_fitness_centar_IB130116.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.Obavjestenje", b =>
                {
                    b.HasOne("Seminarski_fitness_centar_IB130116.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seminarski_fitness_centar_IB130116.Models.Zaposlenik", b =>
                {
                    b.HasOne("Seminarski_fitness_centar_IB130116.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}