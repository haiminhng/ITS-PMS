using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "schueler",
                columns: table => new
                {
                    schuelerid = table.Column<int>(name: "schueler_id", type: "int", nullable: false),
                    vorname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nachname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    klassenname = table.Column<string>(name: "klassen_name", type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schueler", x => x.schuelerid);
                });

            migrationBuilder.CreateTable(
                name: "adressen",
                columns: table => new
                {
                    adresseid = table.Column<short>(name: "adresse_id", type: "smallint", nullable: false),
                    strasse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    hausnr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    plz = table.Column<int>(type: "int", nullable: true),
                    ort = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    land = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    schuelerid = table.Column<int>(name: "schueler_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adressen", x => x.adresseid);
                    table.ForeignKey(
                        name: "adresse_schueler_null_fk",
                        column: x => x.schuelerid,
                        principalTable: "schueler",
                        principalColumn: "schueler_id");
                });

            migrationBuilder.CreateTable(
                name: "parkplatzantrag",
                columns: table => new
                {
                    parkplatzantragsid = table.Column<int>(name: "parkplatzantrags_id", type: "int", nullable: false),
                    kfzkennzeichen = table.Column<string>(name: "kfz_kennzeichen", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    entfernungkm = table.Column<string>(name: "entfernung_km", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    besonderefall = table.Column<bool>(type: "bit", nullable: true),
                    grund = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    mitfahrgelegenheit = table.Column<bool>(type: "bit", nullable: true),
                    moeglichkeit = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    antragsdatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    genehmigt = table.Column<bool>(type: "bit", nullable: true),
                    fahrzeit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    schuelerid = table.Column<int>(name: "schueler_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("parkplatzantrag_pk", x => x.parkplatzantragsid);
                    table.ForeignKey(
                        name: "parkplatzantrag_schueler_null_fk",
                        column: x => x.schuelerid,
                        principalTable: "schueler",
                        principalColumn: "schueler_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_adressen_schueler_id",
                table: "adressen",
                column: "schueler_id",
                unique: true,
                filter: "[schueler_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_adressen_schueler_id1",
                table: "adressen",
                column: "schueler_id");

            migrationBuilder.CreateIndex(
                name: "IX_parkplatzantrag_schueler_id",
                table: "parkplatzantrag",
                column: "schueler_id",
                unique: true,
                filter: "([schueler_id] IS NOT NULL)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adressen");

            migrationBuilder.DropTable(
                name: "parkplatzantrag");

            migrationBuilder.DropTable(
                name: "schueler");
        }
    }
}
