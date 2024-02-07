﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(LibraryAPIDbContext))]
    [Migration("20240206215240_mig_13")]
    partial class mig13
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<Guid>("AuthorBooksBookId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("BookAuthorsAuthorId")
                        .HasColumnType("char(36)");

                    b.HasKey("AuthorBooksBookId", "BookAuthorsAuthorId");

                    b.HasIndex("BookAuthorsAuthorId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<Guid>("BookCategoriesCategoryId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoryBooksBookId")
                        .HasColumnType("char(36)");

                    b.HasKey("BookCategoriesCategoryId", "CategoryBooksBookId");

                    b.HasIndex("CategoryBooksBookId");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("BookInterpreter", b =>
                {
                    b.Property<Guid>("BookInterpretersInterpreterId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("InterpreterBooksBookId")
                        .HasColumnType("char(36)");

                    b.HasKey("BookInterpretersInterpreterId", "InterpreterBooksBookId");

                    b.HasIndex("InterpreterBooksBookId");

                    b.ToTable("BookInterpreter");
                });

            modelBuilder.Entity("BookLanguage", b =>
                {
                    b.Property<Guid>("BookLanguagesLanguageId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("LanguageBooksBookId")
                        .HasColumnType("char(36)");

                    b.HasKey("BookLanguagesLanguageId", "LanguageBooksBookId");

                    b.HasIndex("LanguageBooksBookId");

                    b.ToTable("BookLanguage");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<Guid>("OperationClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OperationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("OperationClaimId");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<Guid>("UserOperationClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("OperationClaimId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserOperationClaimId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AuthorFirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AuthorLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("7d5d9918-8894-47cd-b151-7568cbdcb59f"),
                            AuthorFirstName = "John",
                            AuthorLastName = "Doe",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = new Guid("7374acef-7c4a-4d7c-ad49-3fd5665f2c64"),
                            AuthorFirstName = "Jane",
                            AuthorLastName = "Doe",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = new Guid("669ee76d-5f87-4d14-b5c2-f4475f0b8d0c"),
                            AuthorFirstName = "Michael",
                            AuthorLastName = "Doe",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = new Guid("57deceaa-5ebf-412b-9eb9-22ad3588f202"),
                            AuthorFirstName = "Justin",
                            AuthorLastName = "Doe",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AuthorId = new Guid("895c97d6-5a15-4819-9fb1-42f125803562"),
                            AuthorFirstName = "Domanic",
                            AuthorLastName = "Campbell",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FixtureNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ISBNNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("char(36)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("PublishCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("BookId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("1a0e88d2-2d26-41b6-93b1-735d468ca181"),
                            CategoryName = "Şiir",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = new Guid("e52bb2b5-cffd-4822-8901-474db975313e"),
                            CategoryName = "Hikaye",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = new Guid("c140fe74-88d7-4b49-8dfa-7eca685c58a4"),
                            CategoryName = "Roman",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = new Guid("1c324b42-280c-4ff4-b051-22673a8117aa"),
                            CategoryName = "Deneme",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = new Guid("c70c610e-f442-4e6c-ad2d-55940e4f9ea2"),
                            CategoryName = "Anı",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Entities.Concrete.DepositBook", b =>
                {
                    b.Property<Guid>("DepositBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("BookId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateShouldBeEscrow")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DepositDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("EscrowDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("DepositBookId");

                    b.HasIndex("UserId");

                    b.ToTable("DepositBooks");
                });

            modelBuilder.Entity("Entities.Concrete.Faculty", b =>
                {
                    b.Property<Guid>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Entities.Concrete.Interpreter", b =>
                {
                    b.Property<Guid>("InterpreterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InterpreterFirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InterpreterLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("InterpreterId");

                    b.ToTable("Interpreters");

                    b.HasData(
                        new
                        {
                            InterpreterId = new Guid("d7163905-df9b-4ed6-a426-ab1d09fba731"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterpreterFirstName = "Mustafa",
                            InterpreterLastName = "Kaya"
                        },
                        new
                        {
                            InterpreterId = new Guid("366243fd-e87c-422f-bea6-050d6b9016af"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterpreterFirstName = "Halil Eren",
                            InterpreterLastName = "Yazıcı"
                        },
                        new
                        {
                            InterpreterId = new Guid("7653730d-4b8e-4b71-a9f6-55e6772ee808"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterpreterFirstName = "Kadir",
                            InterpreterLastName = "Korkmaz"
                        },
                        new
                        {
                            InterpreterId = new Guid("6d36c961-649f-47fa-955c-142e60121aa1"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterpreterFirstName = "Baha",
                            InterpreterLastName = "Can"
                        },
                        new
                        {
                            InterpreterId = new Guid("5b908681-6f3b-4463-928f-40de9c9ff054"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterpreterFirstName = "Berkay",
                            InterpreterLastName = "Gürcan"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Language", b =>
                {
                    b.Property<Guid>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("LanguageId");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            LanguageId = new Guid("f72c1123-5065-4e3c-aa99-a53c004e05cf"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LanguageName = "Türkçe"
                        },
                        new
                        {
                            LanguageId = new Guid("15857832-efe5-4efc-a9a9-7cf8c2374858"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LanguageName = "Danca"
                        },
                        new
                        {
                            LanguageId = new Guid("1cc01062-f1d0-413c-90f6-e1b33d340e78"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LanguageName = "İngilizce"
                        },
                        new
                        {
                            LanguageId = new Guid("637a6eec-508c-4358-ab20-78c82e7a0601"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LanguageName = "Almanca"
                        },
                        new
                        {
                            LanguageId = new Guid("f8937ba1-4d7a-44fd-aed9-bb2860bf8132"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LanguageName = "Arapça"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Shelf")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = new Guid("ed1dd8b8-4186-4a53-a847-7d8e6943dd85"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shelf = "A1"
                        },
                        new
                        {
                            LocationId = new Guid("a6161ff7-0ba4-48bd-bed5-6004fa894265"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shelf = "A2"
                        },
                        new
                        {
                            LocationId = new Guid("5a70e086-d809-435f-9cf1-9fd4afbde054"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shelf = "B1"
                        },
                        new
                        {
                            LocationId = new Guid("3a1c8bd9-578e-408f-a7b7-7d4a0c302a07"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shelf = "B2"
                        },
                        new
                        {
                            LocationId = new Guid("49e649bc-0f72-4ca5-9283-d4eef26b7a0f"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shelf = "C1"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Publisher", b =>
                {
                    b.Property<Guid>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherId = new Guid("914cf986-bc1b-4e3f-a674-3e4f2a71e38b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherName = "Ithaki"
                        },
                        new
                        {
                            PublisherId = new Guid("69daac5d-30e0-4f57-8d6b-664a047c160c"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherName = "Kültür"
                        },
                        new
                        {
                            PublisherId = new Guid("ca7ee10f-a5f7-4339-82ff-3f661fc4dcf6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherName = "Mecaz"
                        },
                        new
                        {
                            PublisherId = new Guid("be85ed7e-74f7-421a-bdf2-8a792b8fcfb2"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherName = "Can"
                        },
                        new
                        {
                            PublisherId = new Guid("a33642e6-386c-4375-ad1b-790c51da3e14"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherName = "İş Bankası"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Staff", b =>
                {
                    b.Property<Guid>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("StaffId");

                    b.HasIndex("UserId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Entities.Concrete.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("SchoolNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("StudentId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("Entities.Concrete.Book", null)
                        .WithMany()
                        .HasForeignKey("AuthorBooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Author", null)
                        .WithMany()
                        .HasForeignKey("BookAuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("Entities.Concrete.Category", null)
                        .WithMany()
                        .HasForeignKey("BookCategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Book", null)
                        .WithMany()
                        .HasForeignKey("CategoryBooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookInterpreter", b =>
                {
                    b.HasOne("Entities.Concrete.Interpreter", null)
                        .WithMany()
                        .HasForeignKey("BookInterpretersInterpreterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Book", null)
                        .WithMany()
                        .HasForeignKey("InterpreterBooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookLanguage", b =>
                {
                    b.HasOne("Entities.Concrete.Language", null)
                        .WithMany()
                        .HasForeignKey("BookLanguagesLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Book", null)
                        .WithMany()
                        .HasForeignKey("LanguageBooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Book", b =>
                {
                    b.HasOne("Entities.Concrete.Location", "Location")
                        .WithMany("LocationBooks")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Publisher", "Publisher")
                        .WithMany("PublisherBooks")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Entities.Concrete.DepositBook", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserDepositBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Staff", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Student", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Location", b =>
                {
                    b.Navigation("LocationBooks");
                });

            modelBuilder.Entity("Entities.Concrete.Publisher", b =>
                {
                    b.Navigation("PublisherBooks");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("UserDepositBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
