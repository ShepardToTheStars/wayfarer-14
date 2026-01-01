using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Content.Server.Database.Migrations.Postgres
{
    /// <inheritdoc />
    public partial class WayfarerRoundSummaries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wayfarer_round_summaries",
                columns: table => new
                {
                    round_number = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    round_start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    round_end_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    profit_loss_data = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    player_stories = table.Column<JsonDocument>(type: "jsonb", nullable: true),
                    player_manifest = table.Column<JsonDocument>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wayfarer_round_summaries", x => x.round_number);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wayfarer_round_summaries");
        }
    }
}
