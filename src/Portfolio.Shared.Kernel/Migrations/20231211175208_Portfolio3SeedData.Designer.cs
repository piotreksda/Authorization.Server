﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Portfolio.Shared.Kernel.Infrastructure.EntityFramework;

#nullable disable

namespace Portfolio.Shared.Kernel.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20231211175208_Portfolio3SeedData")]
    partial class Portfolio3SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<bool>("EmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Guid>("SecurityStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValue(new Guid("00000000-0000-0000-0000-000000000000"));

                    b.Property<bool>("TwoFactorEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasDatabaseName("User_UserName");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.LoginHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("timezone('utc', now())");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LoginHistory", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Permissions", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.PermissionPermissionSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionSetId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PermissionSetId");

                    b.HasIndex("PermissionId", "PermissionSetId");

                    b.ToTable("PermissionsPermissionSets", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.PermissionSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("PermissionSets", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.RolePermissionSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionSetId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("PermissionSetId", "RoleId");

                    b.ToTable("RolesPermissionSets", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId");

                    b.ToTable("UsersRoles", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Core.Entities.SmtpConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("EnableSsl")
                        .HasColumnType("boolean");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.Property<string>("SendFrom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SmtpConfigurations");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("IsoCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IsoCode")
                        .IsUnique()
                        .HasFilter("\"Deleted\" = false");

                    b.ToTable("Languages", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int>("LangId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("TranslationContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TranslationKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TranslationTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TranslationTypeId");

                    b.HasIndex("LangId", "TranslationKey")
                        .IsUnique()
                        .HasFilter("\"Deleted\" = false");

                    b.ToTable("Translations", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.TranslationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("\"Deleted\" = false");

                    b.ToTable("TranslationTypes", (string)null);
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationUser", b =>
                {
                    b.OwnsOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("ApplicationUserId")
                                .HasColumnType("integer");

                            b1.Property<string>("Value")
                                .HasMaxLength(64)
                                .HasColumnType("character varying(64)")
                                .HasColumnName("Email");

                            b1.HasKey("ApplicationUserId");

                            b1.HasIndex("Value")
                                .IsUnique()
                                .HasDatabaseName("User_Email");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.OwnsOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ValueObjects.Email", "NormalizedEmail", b1 =>
                        {
                            b1.Property<int>("ApplicationUserId")
                                .HasColumnType("integer");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("character varying(64)")
                                .HasColumnName("NormalizedEmail");

                            b1.HasKey("ApplicationUserId");

                            b1.HasIndex("Value")
                                .IsUnique()
                                .HasDatabaseName("User_NormalizedEmail");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.OwnsOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ValueObjects.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("ApplicationUserId")
                                .HasColumnType("integer");

                            b1.Property<string>("Value")
                                .HasMaxLength(64)
                                .HasColumnType("character varying(64)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("ApplicationUserId");

                            b1.HasIndex("Value")
                                .IsUnique()
                                .HasDatabaseName("User_PhoneNumber")
                                .HasFilter("\"PhoneNumber\" IS NOT NULL");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("NormalizedEmail")
                        .IsRequired();

                    b.Navigation("PhoneNumber");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.LoginHistory", b =>
                {
                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationUser", "User")
                        .WithMany("LoginHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.PermissionPermissionSet", b =>
                {
                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.Permission", "Permission")
                        .WithMany("PermissionPermissionSet")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.PermissionSet", "PermissionSet")
                        .WithMany("PermissionPermissionSet")
                        .HasForeignKey("PermissionSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("PermissionSet");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.RefreshToken", b =>
                {
                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationUser", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ValueObjects.RefreshTokenValue", "Token", b1 =>
                        {
                            b1.Property<int>("RefreshTokenId")
                                .HasColumnType("integer");

                            b1.Property<byte[]>("Value")
                                .IsRequired()
                                .HasColumnType("bytea")
                                .HasColumnName("TokenValue");

                            b1.HasKey("RefreshTokenId");

                            b1.HasIndex("Value")
                                .IsUnique()
                                .HasDatabaseName("RefreshTokens_TokenValue");

                            b1.ToTable("RefreshTokens");

                            b1.WithOwner()
                                .HasForeignKey("RefreshTokenId");
                        });

                    b.Navigation("Token")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.RolePermissionSet", b =>
                {
                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.PermissionSet", "PermissionSet")
                        .WithMany("RolePermissionSets")
                        .HasForeignKey("PermissionSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationRole", "Role")
                        .WithMany("RolesPermissionSets")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionSet");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.UserRole", b =>
                {
                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationRole", "Role")
                        .WithMany("UsersRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationUser", "User")
                        .WithMany("UsersRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.Translation", b =>
                {
                    b.HasOne("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.Language", "Language")
                        .WithMany("Translations")
                        .HasForeignKey("LangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.TranslationType", "TranslationType")
                        .WithMany("Translations")
                        .HasForeignKey("TranslationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("TranslationType");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationRole", b =>
                {
                    b.Navigation("RolesPermissionSets");

                    b.Navigation("UsersRoles");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.ApplicationUser", b =>
                {
                    b.Navigation("LoginHistories");

                    b.Navigation("RefreshTokens");

                    b.Navigation("UsersRoles");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.Permission", b =>
                {
                    b.Navigation("PermissionPermissionSet");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Auth.Entities.PermissionSet", b =>
                {
                    b.Navigation("PermissionPermissionSet");

                    b.Navigation("RolePermissionSets");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.Language", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("Portfolio.Shared.Kernel.Domain.Dictionary.Entities.TranslationType", b =>
                {
                    b.Navigation("Translations");
                });
#pragma warning restore 612, 618
        }
    }
}
