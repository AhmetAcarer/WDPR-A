﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WDPR_A.Migrations
{
    [DbContext(typeof(WDPRContext))]
    partial class WDPRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ChatClient", b =>
                {
                    b.Property<string>("ChatsRoomId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChatsRoomId", "ClientsId");

                    b.HasIndex("ClientsId");

                    b.ToTable("ChatClient");
                });

            modelBuilder.Entity("ClientGuardian", b =>
                {
                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardiansId")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientsId", "GuardiansId");

                    b.HasIndex("GuardiansId");

                    b.ToTable("ClientGuardian");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IncomingClientId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrthopedagogueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IncomingClientId");

                    b.HasIndex("OrthopedagogueId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.Property<string>("RoomId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AgeCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condition")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrthopedagogueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomId");

                    b.HasIndex("OrthopedagogueId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("WDPR_A.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatRoomId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatRoomId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WDPR_A.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("WDPR_A.Models.Client", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<int>("AgeCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PrivateChatToken")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("WDPR_A.Models.Guardian", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AppointmentId");

                    b.HasDiscriminator().HasValue("Guardian");
                });

            modelBuilder.Entity("WDPR_A.Models.Orthopedagogue", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Orthopedagogue");

                    b.HasData(
                        new
                        {
                            Id = "c33fdfad-b57e-4d5d-98b2-3066ec67e560",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03bc4832-79ee-41fc-9e35-17862ebc37a4",
                            Email = "kkemper@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KKEMPER@ZMDH.NL",
                            NormalizedUserName = "KKEMPER@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "35e47597-72fc-4cb1-bed1-504f8f83aa9c",
                            TwoFactorEnabled = false,
                            UserName = "kkemper@zmdh.nl",
                            FirstName = "Karin",
                            LastName = "Kemper",
                            Specialty = "ADHD"
                        },
                        new
                        {
                            Id = "0475a0d0-73b9-4579-989d-69bc233c3b56",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7d32ae1-5f3a-4fa4-a352-b9756f2f17ec",
                            Email = "jlo@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JLO@ZMDH.NL",
                            NormalizedUserName = "JLO@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "26393565-f899-4a1e-8057-a3aa749cd22a",
                            TwoFactorEnabled = false,
                            UserName = "jlo@zmdh.nl",
                            FirstName = "Johan",
                            LastName = "Lo",
                            Specialty = "Faalangst"
                        },
                        new
                        {
                            Id = "b9c72b7a-18ac-407a-94a3-2446b50ad48c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eee0428c-3873-41a1-af41-050ba690e1c6",
                            Email = "sito@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SITO@ZMDH.NL",
                            NormalizedUserName = "SITO@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3c0bd0fb-da4e-45fa-8396-99d690e7ecdb",
                            TwoFactorEnabled = false,
                            UserName = "sito@zmdh.nl",
                            FirstName = "Steven",
                            LastName = "Ito",
                            Specialty = "Eetstoornis"
                        },
                        new
                        {
                            Id = "105fc4a4-e834-414e-8674-f6bed1ed8394",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "534ea111-d039-490d-a4c4-54f6dd7ed1eb",
                            Email = "mvdijk@zmdh.nl",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "MVDIJK@ZMDH.NL",
                            NormalizedUserName = "MVDIJK@ZMDH.NL",
                            PasswordHash = "AQAAAAEAACcQAAAAECliP0eZF/dtPcZTjNEfC7Sh+XjlLTW0LhuATCboH6s/1GZZsLvr9LiQEpMOLZ7pQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f0866808-f0cb-45e6-8ec8-e9214bfc9b1c",
                            TwoFactorEnabled = false,
                            UserName = "mvdijk@zmdh.nl",
                            FirstName = "Marianne",
                            LastName = "van Dijk",
                            Specialty = "Dyslexie"
                        });
                });

            modelBuilder.Entity("ChatClient", b =>
                {
                    b.HasOne("WDPR_A.Models.Chat", null)
                        .WithMany()
                        .HasForeignKey("ChatsRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClientGuardian", b =>
                {
                    b.HasOne("WDPR_A.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Guardian", null)
                        .WithMany()
                        .HasForeignKey("GuardiansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.HasOne("WDPR_A.Models.Client", "IncomingClient")
                        .WithMany()
                        .HasForeignKey("IncomingClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Orthopedagogue", "Orthopedagogue")
                        .WithMany("Appointments")
                        .HasForeignKey("OrthopedagogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomingClient");

                    b.Navigation("Orthopedagogue");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.HasOne("WDPR_A.Models.Orthopedagogue", "Orthopedagogue")
                        .WithMany("Chats")
                        .HasForeignKey("OrthopedagogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orthopedagogue");
                });

            modelBuilder.Entity("WDPR_A.Models.Message", b =>
                {
                    b.HasOne("WDPR_A.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("WDPR_A.Models.Guardian", b =>
                {
                    b.HasOne("WDPR_A.Models.Appointment", null)
                        .WithMany("Guardians")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.Navigation("Guardians");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("WDPR_A.Models.Orthopedagogue", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Chats");
                });
#pragma warning restore 612, 618
        }
    }
}
