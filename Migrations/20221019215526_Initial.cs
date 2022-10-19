using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEVinCar.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhonetes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumeroChassi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CpfComprador = table.Column<long>(type: "bigint", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Portas = table.Column<int>(type: "int", nullable: false),
                    Gasolisa = table.Column<bool>(type: "bit", nullable: false),
                    CapacidadeCacamba = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhonetes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumeroChassi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CpfComprador = table.Column<long>(type: "bigint", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Portas = table.Column<int>(type: "int", nullable: false),
                    Gasolisa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotoTriciclos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumeroChassi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFabricacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CpfComprador = table.Column<long>(type: "bigint", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rodas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoTriciclos", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Caminhonetes",
                columns: new[] { "Id", "CapacidadeCacamba", "Cor", "CpfComprador", "DataFabricacao", "Gasolisa", "Nome", "NumeroChassi", "Placa", "Portas", "Potencia", "Tipo", "Valor" },
                values: new object[,]
                {
                    { "CAM1", 300, "Verde", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(6523), false, "F1000", "LAL97ZP13DWDU3FRW", "YMP-1578", 2, 1000, "Caminhonete", 60000m },
                    { "CAM2", 250, "Cinza", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(9394), false, "F500", "JJGB28NVX7NNL0BDB", "WNX-5313", 2, 500, "Caminhonete", 55000m },
                    { "CAM3", 250, "Preto", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(9425), true, "F250", "Z1X6JT9TYYWC54APJ", "RUK-3804", 2, 250, "Caminhonete", 45000m }
                });

            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataFabricacao", "Gasolisa", "Nome", "NumeroChassi", "Placa", "Portas", "Potencia", "Tipo", "Valor" },
                values: new object[,]
                {
                    { "CAR1", "Cinza", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 923, DateTimeKind.Local).AddTicks(4451), false, "Ford Focus", "ETSXA0PA6X2VSNT94", "DXW-3713", 4, 250, "Carro", 45000m },
                    { "CAR2", "Branco", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(2472), false, "Punto", "FMHFG5BV3JSY06AS2", "PYG-8555", 2, 350, "Carro", 47500m },
                    { "CAR3", "Azul", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 949, DateTimeKind.Local).AddTicks(2616), false, "Gol", "UTGR9WV77HUNAPBA0", "HML-3163", 4, 200, "Carro", 30000m }
                });

            migrationBuilder.InsertData(
                table: "MotoTriciclos",
                columns: new[] { "Id", "Cor", "CpfComprador", "DataFabricacao", "Nome", "NumeroChassi", "Placa", "Potencia", "Rodas", "Tipo", "Valor" },
                values: new object[,]
                {
                    { "MOT1", "Vermelho", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 950, DateTimeKind.Local).AddTicks(2193), "CG150", "HA36SE1RD8RLUVKTP", "LKV-1418", 150, 2, "MotoTriciclo", 8500m },
                    { "MOT2", "Branco", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 950, DateTimeKind.Local).AddTicks(4897), "Honda Biz", "X15GUZEVBHXAMJB1D", "ZJD-6083", 100, 2, "MotoTriciclo", 5500m },
                    { "MOT3", "Azul", 0L, new DateTime(2022, 10, 18, 18, 55, 25, 950, DateTimeKind.Local).AddTicks(5003), "Triciclo 3E", "60A8JUCSADY6GWAGP", "SSO-0834", 125, 3, "MotoTriciclo", 11500m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Nome", "Password" },
                values: new object[,]
                {
                    { 1, "yan@email.com", "Yan", "123456" },
                    { 2, "joao@email.com", "Joao", "123123" },
                    { 3, "support@email.com", "Support", "123123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhonetes");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "MotoTriciclos");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
