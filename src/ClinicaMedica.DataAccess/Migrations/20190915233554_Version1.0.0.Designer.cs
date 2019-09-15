﻿// <auto-generated />
using System;
using ClinicaMedica.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaMedica.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190915233554_Version1.0.0")]
    partial class Version100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Cita", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("DoctorId");

                    b.Property<int>("EstadoCitaId");

                    b.Property<DateTime>("Fecha");

                    b.Property<TimeSpan>("Hora");

                    b.Property<int>("PacienteId");

                    b.HasKey("CitaId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("EstadoCitaId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Dui");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nit");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.Property<int>("UsuarioId");

                    b.HasKey("DoctorId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.DoctorEspecialidad", b =>
                {
                    b.Property<int>("DoctorEspecialidadId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId");

                    b.Property<int>("EspecialidadId");

                    b.HasKey("DoctorEspecialidadId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("EspecialidadId");

                    b.ToTable("DoctorEspecialidad");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Especialidad", b =>
                {
                    b.Property<int>("EspecialidadId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("EspecialidadId");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("EstadoId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario");

                    b.Property<string>("Correlativo");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime?>("CreateOn");

                    b.Property<string>("DeleteBy");

                    b.Property<DateTime?>("DeleteOn");

                    b.Property<DateTime>("FechaEmision");

                    b.Property<string>("ModifyBy");

                    b.Property<DateTime?>("ModifyOn");

                    b.Property<int>("PacienteId");

                    b.HasKey("FacturaId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.FacturaDetalle", b =>
                {
                    b.Property<int>("FacturaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cantidad");

                    b.Property<string>("Descripcion");

                    b.Property<int?>("FacturaId");

                    b.Property<decimal>("Precio");

                    b.HasKey("FacturaDetalleId");

                    b.HasIndex("FacturaId");

                    b.ToTable("FacturaDetalle");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.HistorialMedico", b =>
                {
                    b.Property<int>("HistorialMedicoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CitaId");

                    b.Property<string>("Comentario");

                    b.Property<string>("Diagnostico");

                    b.Property<DateTime>("Fecha");

                    b.Property<decimal>("PasienteEstatura");

                    b.Property<decimal>("PasientePeso");

                    b.Property<decimal>("PresionSanguinea");

                    b.HasKey("HistorialMedicoId");

                    b.HasIndex("CitaId");

                    b.ToTable("HistorialesMedicos");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.HistorialMedicoDetalle", b =>
                {
                    b.Property<int>("HistorialMedicoDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dosis");

                    b.Property<int?>("HistorialMedicoId");

                    b.Property<int>("MedicamentoUnidadId");

                    b.HasKey("HistorialMedicoDetalleId");

                    b.HasIndex("HistorialMedicoId");

                    b.HasIndex("MedicamentoUnidadId");

                    b.ToTable("HistorialMedicoDetalles");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Medicamento", b =>
                {
                    b.Property<int>("MedicamentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraindicaciones");

                    b.Property<string>("Indicaciones");

                    b.Property<string>("Nombre");

                    b.HasKey("MedicamentoId");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.MedicamentoUnidad", b =>
                {
                    b.Property<int>("MedicamentoUnidadId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MedicamentoId");

                    b.Property<decimal>("Precio");

                    b.Property<int>("UnidadMedidaId");

                    b.HasKey("MedicamentoUnidadId");

                    b.HasIndex("MedicamentoId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("MedicamentoUnidad");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlergicoA");

                    b.Property<string>("Apellido");

                    b.Property<string>("Direccion");

                    b.Property<string>("Dui");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<bool>("Genero");

                    b.Property<string>("Nit");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.Property<string>("TipoSangre");

                    b.HasKey("PacienteId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.UnidadMedida", b =>
                {
                    b.Property<int>("UnidadMedidaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abreviatura");

                    b.Property<string>("Nombre");

                    b.HasKey("UnidadMedidaId");

                    b.ToTable("UnidadesDeMedidas");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int>("RolId");

                    b.Property<string>("User");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Cita", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClinicaMedica.DataAccess.Entities.Estado", "EstadoCita")
                        .WithMany()
                        .HasForeignKey("EstadoCitaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClinicaMedica.DataAccess.Entities.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Doctor", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.DoctorEspecialidad", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClinicaMedica.DataAccess.Entities.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Factura", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.FacturaDetalle", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Factura")
                        .WithMany("Detalles")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.HistorialMedico", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Cita", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.HistorialMedicoDetalle", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.HistorialMedico")
                        .WithMany("Detalles")
                        .HasForeignKey("HistorialMedicoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClinicaMedica.DataAccess.Entities.MedicamentoUnidad", "MedicamentoUnidad")
                        .WithMany()
                        .HasForeignKey("MedicamentoUnidadId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.MedicamentoUnidad", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Medicamento", "Medicamento")
                        .WithMany()
                        .HasForeignKey("MedicamentoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClinicaMedica.DataAccess.Entities.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClinicaMedica.DataAccess.Entities.Usuario", b =>
                {
                    b.HasOne("ClinicaMedica.DataAccess.Entities.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
