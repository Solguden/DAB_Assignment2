using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB_Assignment2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "waiters",
                columns: table => new
                {
                    WaiterId = table.Column<string>(nullable: false),
                    Salary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waiters", x => x.WaiterId);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    ReviewId = table.Column<string>(nullable: false),
                    Stars = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_reviews_restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dishes",
                columns: table => new
                {
                    DishId = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    DishName = table.Column<string>(nullable: true),
                    ReviewId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishes", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_dishes_reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    GuestId = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    ReviewsReviewId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_guests_reviews_ReviewsReviewId",
                        column: x => x.ReviewsReviewId,
                        principalTable: "reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantDish",
                columns: table => new
                {
                    RestaurantId = table.Column<string>(nullable: false),
                    DishId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantDish", x => new { x.DishId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantDish_dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantDish_restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestDish",
                columns: table => new
                {
                    GuestId = table.Column<string>(nullable: false),
                    DishId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestDish", x => new { x.GuestId, x.DishId });
                    table.ForeignKey(
                        name: "FK_GuestDish_dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestDish_guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WaiterID = table.Column<string>(nullable: true),
                    GuestID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_waiters_WaiterID",
                        column: x => x.WaiterID,
                        principalTable: "waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    TableId = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<string>(nullable: true),
                    GuestId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_tables_guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tables_restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaiterTable",
                columns: table => new
                {
                    WaiterId = table.Column<string>(nullable: false),
                    TableId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaiterTable", x => new { x.WaiterId, x.TableId });
                    table.ForeignKey(
                        name: "FK_WaiterTable_tables_TableId",
                        column: x => x.TableId,
                        principalTable: "tables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaiterTable_waiters_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dishes_ReviewId",
                table: "dishes",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestDish_DishId",
                table: "GuestDish",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_guests_ReviewsReviewId",
                table: "guests",
                column: "ReviewsReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_People_GuestID",
                table: "People",
                column: "GuestID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_WaiterID",
                table: "People",
                column: "WaiterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDish_RestaurantId",
                table: "RestaurantDish",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_RestaurantId",
                table: "reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_tables_GuestId",
                table: "tables",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_tables_RestaurantId",
                table: "tables",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_WaiterTable_TableId",
                table: "WaiterTable",
                column: "TableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestDish");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "RestaurantDish");

            migrationBuilder.DropTable(
                name: "WaiterTable");

            migrationBuilder.DropTable(
                name: "dishes");

            migrationBuilder.DropTable(
                name: "tables");

            migrationBuilder.DropTable(
                name: "waiters");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "restaurants");
        }
    }
}
