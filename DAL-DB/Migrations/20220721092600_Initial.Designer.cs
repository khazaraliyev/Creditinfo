using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DB.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220721092600_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IndividualNationalId")
                        .HasColumnType("int");

                    b.Property<string>("InstallmentAmountCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstallmentAmountValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalAmountCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalAmountValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhaseOfContract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleOfCustomer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IndividualNationalId")
                        .IsUnique();

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Domain.Entities.Individual", b =>
                {
                    b.Property<int>("NationalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalId");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("Domain.Entities.Contract", b =>
                {
                    b.HasOne("Domain.Entities.Individual", "Individual")
                        .WithOne("Contract")
                        .HasForeignKey("Domain.Entities.Contract", "IndividualNationalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
