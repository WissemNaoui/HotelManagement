using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using HotelManagement.Infrastructure.Data;
using HotelManagement.Domain.Entities;

namespace HotelManagement.Infrastructure.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagement.Domain.Entities.Customer", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Address")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<bool>("IsActive")
                    .HasColumnType("bit");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("PhoneNumber")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<DateTime>("RegistrationDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Customers");
            });

            modelBuilder.Entity("HotelManagement.Domain.Entities.Reservation", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CheckInDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("CheckOutDate")
                    .HasColumnType("datetime2");

                b.Property<int>("CustomerId")
                    .HasColumnType("int");

                b.Property<int>("RoomId")
                    .HasColumnType("int");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<decimal>("TotalPrice")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("Id");

                b.HasIndex("CustomerId");

                b.HasIndex("RoomId");

                b.ToTable("Reservations");
            });

            modelBuilder.Entity("HotelManagement.Domain.Entities.Room", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.Property<decimal>("PricePerNight")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("RoomNumber")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar(10)");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<int>("Type")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Rooms");
            });

            modelBuilder.Entity("HotelManagement.Domain.Entities.Reservation", b =>
            {
                b.HasOne("HotelManagement.Domain.Entities.Customer", "Customer")
                    .WithMany()
                    .HasForeignKey("CustomerId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("HotelManagement.Domain.Entities.Room", "Room")
                    .WithMany()
                    .HasForeignKey("RoomId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Customer");

                b.Navigation("Room");
            });
        }
    }
}
