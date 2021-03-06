﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using web_voting_sys.Data;
using web_voting_sys.Model;

namespace web_voting_sys.Migrations
{
    [DbContext(typeof(PollContext))]
    [Migration("20180418215239_WebVotingSys2")]
    partial class WebVotingSys2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("web_voting_sys.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int?>("PollID");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("PollID");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("web_voting_sys.Model.Poll", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfQuestions");

                    b.Property<string>("PollCreator");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("Poll");
                });

            modelBuilder.Entity("web_voting_sys.Model.PollChoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Choice");

                    b.Property<int?>("PollQuestionID");

                    b.Property<int>("VoteTally");

                    b.HasKey("ID");

                    b.HasIndex("PollQuestionID");

                    b.ToTable("PollChoice");
                });

            modelBuilder.Entity("web_voting_sys.Model.PollQuestion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PollID");

                    b.Property<string>("Question");

                    b.HasKey("ID");

                    b.HasIndex("PollID");

                    b.ToTable("PollQuestion");
                });

            modelBuilder.Entity("web_voting_sys.Data.ApplicationUser", b =>
                {
                    b.HasOne("web_voting_sys.Model.Poll")
                        .WithMany("Voters")
                        .HasForeignKey("PollID");
                });

            modelBuilder.Entity("web_voting_sys.Model.PollChoice", b =>
                {
                    b.HasOne("web_voting_sys.Model.PollQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("PollQuestionID");
                });

            modelBuilder.Entity("web_voting_sys.Model.PollQuestion", b =>
                {
                    b.HasOne("web_voting_sys.Model.Poll")
                        .WithMany("Questions")
                        .HasForeignKey("PollID");
                });
#pragma warning restore 612, 618
        }
    }
}
