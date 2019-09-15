using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaMedica.DataAccess.Migrations
{
    public partial class Version100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Medicamentos_MedicamentoId",
                table: "FacturaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorialMedicoDetalles_Medicamentos_MedicamentoId",
                table: "HistorialMedicoDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_UnidadesDeMedidas_UnidadId",
                table: "Medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Usuarios_UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Medicamentos_UnidadId",
                table: "Medicamentos");

            migrationBuilder.DropIndex(
                name: "IX_FacturaDetalle_MedicamentoId",
                table: "FacturaDetalle");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "UnidadId",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "MedicamentoId",
                table: "FacturaDetalle");

            migrationBuilder.RenameColumn(
                name: "MedicamentoId",
                table: "HistorialMedicoDetalles",
                newName: "MedicamentoUnidadId");

            migrationBuilder.RenameIndex(
                name: "IX_HistorialMedicoDetalles_MedicamentoId",
                table: "HistorialMedicoDetalles",
                newName: "IX_HistorialMedicoDetalles_MedicamentoUnidadId");

            migrationBuilder.RenameColumn(
                name: "Prefijo",
                table: "Facturas",
                newName: "ModifyBy");

            migrationBuilder.AddColumn<string>(
                name: "AlergicoA",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Facturas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateOn",
                table: "Facturas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "Facturas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteOn",
                table: "Facturas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyOn",
                table: "Facturas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "FacturaDetalle",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "FacturaDetalle",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Hora",
                table: "Citas",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.CreateTable(
                name: "MedicamentoUnidad",
                columns: table => new
                {
                    MedicamentoUnidadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UnidadMedidaId = table.Column<int>(nullable: false),
                    MedicamentoId = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentoUnidad", x => x.MedicamentoUnidadId);
                    table.ForeignKey(
                        name: "FK_MedicamentoUnidad_Medicamentos_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicamentoUnidad_UnidadesDeMedidas_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadesDeMedidas",
                        principalColumn: "UnidadMedidaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentoUnidad_MedicamentoId",
                table: "MedicamentoUnidad",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentoUnidad_UnidadMedidaId",
                table: "MedicamentoUnidad",
                column: "UnidadMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialMedicoDetalles_MedicamentoUnidad_MedicamentoUnidadId",
                table: "HistorialMedicoDetalles",
                column: "MedicamentoUnidadId",
                principalTable: "MedicamentoUnidad",
                principalColumn: "MedicamentoUnidadId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorialMedicoDetalles_MedicamentoUnidad_MedicamentoUnidadId",
                table: "HistorialMedicoDetalles");

            migrationBuilder.DropTable(
                name: "MedicamentoUnidad");

            migrationBuilder.DropColumn(
                name: "AlergicoA",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "CreateOn",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "DeleteOn",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "ModifyOn",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "FacturaDetalle");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "FacturaDetalle");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "MedicamentoUnidadId",
                table: "HistorialMedicoDetalles",
                newName: "MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_HistorialMedicoDetalles_MedicamentoUnidadId",
                table: "HistorialMedicoDetalles",
                newName: "IX_HistorialMedicoDetalles_MedicamentoId");

            migrationBuilder.RenameColumn(
                name: "ModifyBy",
                table: "Facturas",
                newName: "Prefijo");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadId",
                table: "Medicamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicamentoId",
                table: "FacturaDetalle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_UnidadId",
                table: "Medicamentos",
                column: "UnidadId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetalle_MedicamentoId",
                table: "FacturaDetalle",
                column: "MedicamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Medicamentos_MedicamentoId",
                table: "FacturaDetalle",
                column: "MedicamentoId",
                principalTable: "Medicamentos",
                principalColumn: "MedicamentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorialMedicoDetalles_Medicamentos_MedicamentoId",
                table: "HistorialMedicoDetalles",
                column: "MedicamentoId",
                principalTable: "Medicamentos",
                principalColumn: "MedicamentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_UnidadesDeMedidas_UnidadId",
                table: "Medicamentos",
                column: "UnidadId",
                principalTable: "UnidadesDeMedidas",
                principalColumn: "UnidadMedidaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Usuarios_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
