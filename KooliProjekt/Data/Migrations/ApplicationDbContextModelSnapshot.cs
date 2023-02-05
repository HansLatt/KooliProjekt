﻿// <auto-generated />
using KooliProjekt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KooliProjekt.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KooliProjekt.Data.Päevik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Harjutus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kordused")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Päevik");
                });

            modelBuilder.Entity("KooliProjekt.Data.PäevikSisu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Harjutus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kordused")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PäevikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PäevikId");

                    b.ToTable("PäevikSisu");
                });

            modelBuilder.Entity("KooliProjekt.Data.PäevikSisu", b =>
                {
                    b.HasOne("KooliProjekt.Data.Päevik", "Päevik")
                        .WithMany("Sisu")
                        .HasForeignKey("PäevikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Päevik");
                });

            modelBuilder.Entity("KooliProjekt.Data.Päevik", b =>
                {
                    b.Navigation("Sisu");
                });
#pragma warning restore 612, 618
        }
    }
}