using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product_Management.Data;

#nullable disable

namespace Product_Management.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240201123346_image upload")]
    partial class imageupload
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Product_Management.Models.DomainModels.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");
                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));
                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.HasKey("CategoryId");
                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Product_Management.Models.DomainModels.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");
                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");
                    b.Property<bool>("IsTrending")
                        .HasColumnType("bit");
                    b.Property<DateTime>("ProductCreatedAt")
                        .HasColumnType("datetime2");
                    b.Property<string>("ProductDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("ProductImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");
                    b.HasKey("ProductId");
                    b.HasIndex("CategoryId");
                    b.ToTable("Products");
                });

            modelBuilder.Entity("Product_Management.Models.DomainModels.Product", b =>
                {
                    b.HasOne("Product_Management.Models.DomainModels.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}