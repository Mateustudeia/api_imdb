﻿// <auto-generated />
using System;
using Imdb.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Imdb.Infra.Migrations
{
    [DbContext(typeof(ImdbContext))]
    [Migration("20201016184510_Migration01")]
    partial class Migration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("imdb")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Imdb.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Ano")
                        .HasColumnName("ano")
                        .HasColumnType("integer");

                    b.Property<string>("Atores")
                        .IsRequired()
                        .HasColumnName("atores")
                        .HasColumnType("text");

                    b.Property<string>("Diretor")
                        .IsRequired()
                        .HasColumnName("diretor")
                        .HasColumnType("text");

                    b.Property<string>("Enredo")
                        .IsRequired()
                        .HasColumnName("enredo")
                        .HasColumnType("text");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnName("genero")
                        .HasColumnType("text");

                    b.Property<TimeSpan>("TempoDuracao")
                        .HasColumnName("tempo_duracao")
                        .HasColumnType("interval");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("movie");
                });

            modelBuilder.Entity("Imdb.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("date_of_birth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Imdb.Domain.Entities.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("VoteScore")
                        .HasColumnName("vote_score")
                        .HasColumnType("integer");

                    b.Property<int>("movie_id")
                        .HasColumnType("integer");

                    b.Property<int>("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("movie_id");

                    b.HasIndex("user_id");

                    b.ToTable("vote_user_movie");
                });

            modelBuilder.Entity("Imdb.Domain.Entities.Vote", b =>
                {
                    b.HasOne("Imdb.Domain.Entities.Movie", "Movie")
                        .WithMany("VoteMovie")
                        .HasForeignKey("movie_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imdb.Domain.Entities.User", "User")
                        .WithMany("VoteMovie")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}