using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEVinCar.Migrations
{
    public partial class AddSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Caminhonetes",
                keyColumn: "Id",
                keyValue: "CAM1");

            migrationBuilder.DeleteData(
                table: "Caminhonetes",
                keyColumn: "Id",
                keyValue: "CAM2");

            migrationBuilder.DeleteData(
                table: "Caminhonetes",
                keyColumn: "Id",
                keyValue: "CAM3");

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: "CAR1");

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: "CAR2");

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: "CAR3");

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: "MOT1");

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: "MOT2");

            migrationBuilder.DeleteData(
                table: "MotoTriciclos",
                keyColumn: "Id",
                keyValue: "MOT3");

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CpfComprador = table.Column<long>(type: "bigint", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.InsertData(
                table: "Caminhonetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Cor", "CpfComprador", "DataFabricacao", "Gasolisa", "Nome", "NumeroChassi", "Placa", "Portas", "Potencia", "Tipo", "Valor" },
                values: new object[,]
                {
                    { "CAM1", 300, "Verde", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(5919), false, "F1000", "T0WYUN9A2FZVH2SK4", "EJE-0043", 2, 1000, "Caminhonete", 60000m },
                    { "CAM2", 250, "Cinza", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(8682), false, "F500", "09VY8CJ0W0M0NK9PM", "VXO-5450", 2, 500, "Caminhonete", 55000m },
                    { "CAM3", 250, "Preto", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(8722), true, "F250", "623MP639CG95VERS9", "KHH-2000", 2, 250, "Caminhonete", 45000m }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataFabricacao", "Gasolisa", "Nome", "NumeroChassi", "Placa", "Portas", "Potencia", "Tipo", "Valor" },
                values: new object[,]
                {
                    { "CAR1", "Cinza", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 397, DateTimeKind.Local).AddTicks(2485), false, "Ford Focus", "F9DNMSZH0XX30N91K", "KAD-1316", 4, 250, "Carro", 45000m },
                    { "CAR2", "Branco", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(1842), false, "Punto", "MB47871CMDEBMSF5Y", "TPD-3335", 2, 350, "Carro", 47500m },
                    { "CAR3", "Azul", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 401, DateTimeKind.Local).AddTicks(1883), false, "Gol", "C9GJJ18EJU7P3HMEG", "WRE-7266", 4, 200, "Carro", 30000m }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataFabricacao", "Nome", "NumeroChassi", "Placa", "Potencia", "Rodas", "Tipo", "Valor" },
                values: new object[,]
                {
                    { "MOT1", "Vermelho", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 402, DateTimeKind.Local).AddTicks(1475), "CG150", "VSWZMHBLVUYUZ3XJR", "ZDO-8508", 150, 2, "MotoTriciclo", 8500m },
                    { "MOT2", "Branco", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 402, DateTimeKind.Local).AddTicks(4344), "Honda Biz", "B2R7SZB3J4V176YL5", "RPA-8534", 100, 2, "MotoTriciclo", 5500m },
                    { "MOT3", "Azul", 0L, new DateTime(2022, 10, 11, 18, 42, 1, 402, DateTimeKind.Local).AddTicks(4431), "Triciclo 3E", "39T96H4FR7W9D3F9A", "XKM-0053", 125, 3, "MotoTriciclo", 11500m }
                });
        }
    }
}
