﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Study2gether.Models;

namespace Study2gether.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AxisPost", b =>
                {
                    b.Property<Guid>("AxesidAxis")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostsidPost")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AxesidAxis", "PostsidPost");

                    b.HasIndex("PostsidPost");

                    b.ToTable("AxisPost");
                });

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.Property<Guid>("CategoriesidCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostsidPost")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesidCategory", "PostsidPost");

                    b.HasIndex("PostsidPost");

                    b.ToTable("CategoryPost");
                });

            modelBuilder.Entity("MicrofoundationPost", b =>
                {
                    b.Property<Guid>("MicrofoundationsidMicrofoundation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostsidPost")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MicrofoundationsidMicrofoundation", "PostsidPost");

                    b.HasIndex("PostsidPost");

                    b.ToTable("MicrofoundationPost");
                });

            modelBuilder.Entity("Study2gether.Models.Answer", b =>
                {
                    b.Property<Guid>("idAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("idPost")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAnswer");

                    b.HasIndex("idPost");

                    b.HasIndex("idUser");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Study2gether.Models.Axis", b =>
                {
                    b.Property<Guid>("idAxis")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAxis");

                    b.ToTable("Axis");
                });

            modelBuilder.Entity("Study2gether.Models.Category", b =>
                {
                    b.Property<Guid>("idCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCategory");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Study2gether.Models.Microfoundation", b =>
                {
                    b.Property<Guid>("idMicrofoundation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMicrofoundation");

                    b.ToTable("Microfoundation");
                });

            modelBuilder.Entity("Study2gether.Models.Post", b =>
                {
                    b.Property<Guid>("idPost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<int>("views")
                        .HasColumnType("int");

                    b.HasKey("idPost");

                    b.HasIndex("idUser");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Study2gether.Models.Reaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("idAnswer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("idPost")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("idAnswer");

                    b.HasIndex("idPost");

                    b.HasIndex("idUser");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("Study2gether.Models.User", b =>
                {
                    b.Property<Guid>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialMedia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AxisPost", b =>
                {
                    b.HasOne("Study2gether.Models.Axis", null)
                        .WithMany()
                        .HasForeignKey("AxesidAxis")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Study2gether.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsidPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryPost", b =>
                {
                    b.HasOne("Study2gether.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesidCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Study2gether.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsidPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MicrofoundationPost", b =>
                {
                    b.HasOne("Study2gether.Models.Microfoundation", null)
                        .WithMany()
                        .HasForeignKey("MicrofoundationsidMicrofoundation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Study2gether.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsidPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Study2gether.Models.Answer", b =>
                {
                    b.HasOne("Study2gether.Models.Post", "Post")
                        .WithMany("Answers")
                        .HasForeignKey("idPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Study2gether.Models.User", "User")
                        .WithMany("Answers")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Study2gether.Models.Post", b =>
                {
                    b.HasOne("Study2gether.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Study2gether.Models.Reaction", b =>
                {
                    b.HasOne("Study2gether.Models.Answer", "Answer")
                        .WithMany("Reactions")
                        .HasForeignKey("idAnswer");

                    b.HasOne("Study2gether.Models.Post", "Post")
                        .WithMany("Reactions")
                        .HasForeignKey("idPost");

                    b.HasOne("Study2gether.Models.User", "User")
                        .WithMany("Reactions")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Study2gether.Models.Answer", b =>
                {
                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("Study2gether.Models.Post", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("Study2gether.Models.User", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Posts");

                    b.Navigation("Reactions");
                });
#pragma warning restore 612, 618
        }
    }
}
