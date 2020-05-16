﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualWhiteboardAPI.Models.DataAccess;

namespace VirtualWhiteboardAPI.Migrations
{
    [DbContext(typeof(VirtualWhiteboardContext))]
    [Migration("20200516104342_addidtoposttowhiteboard")]
    partial class addidtoposttowhiteboard
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostedBy_Id")
                        .HasColumnType("int");

                    b.Property<int?>("PostedOn_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostedBy_Id");

                    b.HasIndex("PostedOn_Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WhiteboardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WhiteboardId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MemberOfId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MemberOfId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.Whiteboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Whiteboards");
                });

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.Post", b =>
                {
                    b.HasOne("VirtualWhiteboardAPI.Models.User", "PostedBy")
                        .WithMany()
                        .HasForeignKey("PostedBy_Id");

                    b.HasOne("VirtualWhiteboardAPI.Models.Whiteboard", "PostedOn")
                        .WithMany("Posts")
                        .HasForeignKey("PostedOn_Id");
                });

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.Team", b =>
                {
                    b.HasOne("VirtualWhiteboardAPI.Models.Whiteboard", "Whiteboard")
                        .WithMany()
                        .HasForeignKey("WhiteboardId");
                });

            modelBuilder.Entity("VirtualWhiteboardAPI.Models.User", b =>
                {
                    b.HasOne("VirtualWhiteboardAPI.Models.Team", "MemberOf")
                        .WithMany("Members")
                        .HasForeignKey("MemberOfId");
                });
#pragma warning restore 612, 618
        }
    }
}
