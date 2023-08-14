using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SantiyeYonetim.DataAccess.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    County = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionRowNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SmallName = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectTypes_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalTable: "ProjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectBlocks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFloors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectBlockId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFloors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectFloors_ProjectBlocks_ProjectBlockId",
                        column: x => x.ProjectBlockId,
                        principalTable: "ProjectBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProductionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectFloorId = table.Column<int>(type: "int", nullable: false),
                    ProductionTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProductionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProductionTypes_ProductionTypes_ProductionTypeId",
                        column: x => x.ProductionTypeId,
                        principalTable: "ProductionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProductionTypes_ProjectFloors_ProjectFloorId",
                        column: x => x.ProjectFloorId,
                        principalTable: "ProjectFloors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductionId = table.Column<int>(type: "int", nullable: false),
                    ProjectProductionTypeId = table.Column<int>(type: "int", nullable: false),
                    DrawingFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductionEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalProductionDays = table.Column<int>(type: "int", nullable: false),
                    AdminNote = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserNote = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompletionStatus = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedPeople = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProductions_Productions_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectProductions_ProjectProductionTypes_ProjectProductionTypeId",
                        column: x => x.ProjectProductionTypeId,
                        principalTable: "ProjectProductionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectProductionImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectProductionId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectProductionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectProductionImages_ProjectProductions_ProjectProductionId",
                        column: x => x.ProjectProductionId,
                        principalTable: "ProjectProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 3, "60a60eda-9854-4be3-abde-440fc9eaef77", "ProjectAdmin Account", "ProjectAdmin", "PROJECTADMİN" },
                    { 1, "f14eb7ba-176d-460d-a338-bac7eb12b579", "Admin Account", "Admin", "ADMİN" },
                    { 2, "d0cfa4d4-0781-4a43-80e6-5ac78065bf0f", "User Account", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName", "Description" },
                values: new object[,]
                {
                    { 1, "Semih İnşaat", "Description" },
                    { 3, "Hamza İnşaat", "Deneme Açıklaması2" },
                    { 2, "Halil İnşaat", "Deneme Açıklaması" }
                });

            migrationBuilder.InsertData(
                table: "ProductionTypes",
                columns: new[] { "Id", "Name", "SmallName" },
                values: new object[,]
                {
                    { 5, "MAKİNE İŞLERİ", "M" },
                    { 4, "ELEKTRİK İŞLERİ", "E" },
                    { 3, "İNCE İŞLER", "İ" },
                    { 2, "KABA İŞLER", "K" },
                    { 1, "HAFRİYAT", "H" }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Description", "Name", "ProductionRowNumber" },
                values: new object[,]
                {
                    { 51, "Description", "BİNA GİRİŞ İMALATLARI", 1 },
                    { 50, "Description", "DUŞAKABİN MONTAJI", 1 },
                    { 49, "Description", "HALI KAPLAMA", 1 },
                    { 48, "Description", "KABA TEMİZLİK", 1 },
                    { 47, "Description", "KABA TEMİZLİK", 1 },
                    { 46, "Description", "PARKE KAPLAMA", 1 },
                    { 43, "Description", "PORTMANTO ve GÖMME DOLAP", 1 },
                    { 44, "Description", "ANKASTRE BEYAZ EŞYA", 1 },
                    { 52, "Description", "İNCE TEMİZLİK", 1 },
                    { 42, "Description", "BANYO DOLAPLARI", 1 },
                    { 41, "Description", "MUTFAK DOLAPLARI", 1 },
                    { 1, "Description", "HAFRİYAT", 1 },
                    { 45, "Description", "MDF SÜPÜRGELİK", 1 },
                    { 53, "Description", "ELEKTRİK İMALATLARI (1. GRUP)", 1 },
                    { 56, "Description", "ELEKTRİK TEST", 1 },
                    { 55, "Description", "ELEKTRİK İMALATLARI (2. GRUP)", 1 },
                    { 39, "Description", "DAİRE İÇ KAPILARI", 1 },
                    { 57, "Description", "SIHHİ TESİSAT", 1 },
                    { 58, "Description", "YANGIN TESİSATI", 1 },
                    { 59, "Description", "KALORİFER TESİSATI", 1 },
                    { 60, "Description", "ASANSÖR RAY MONTAJI", 1 },
                    { 61, "Description", "ASANSÖR KAPI KASA MONTAJI", 1 },
                    { 62, "Description", "DOĞALGAZ TESİSATI", 1 },
                    { 63, "Description", "ASANSÖR MAKİNE MOTOR", 1 },
                    { 64, "Description", "RADYATÖR PANEL MONTAJI", 1 },
                    { 65, "Description", "VİTRİFİYE ARMATÜR MONTAJI", 1 },
                    { 66, "Description", "ASANSÖR KABİN MONTAJI", 1 },
                    { 67, "Description", "MEKANİK TEST", 1 },
                    { 54, "Description", "ELEKTRİK ARMATÜR MONTAJI", 1 },
                    { 2, "Description", "DOLGU", 1 },
                    { 40, "Description", "ŞAFT KAPAK ve DOLAPLARI", 1 }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Description", "Name", "ProductionRowNumber" },
                values: new object[,]
                {
                    { 36, "Description", "DAİRE GİRİŞ KAPILARI", 1 },
                    { 16, "Description", "İÇ CEPHE ISI İZOLASYONU", 1 },
                    { 15, "Description", "KARA SIVA ( İÇ - DIŞ )", 1 },
                    { 14, "Description", "İÇ DIŞ ÖRME DUVARLAR", 1 },
                    { 13, "Description", "ÇATI İŞLERİ", 1 },
                    { 12, "Description", "DIŞ CEPHE PREKAST MONTAJI", 1 },
                    { 11, "Description", "MERDİVEN PREKAST MONTAJI", 1 },
                    { 37, "Description", "ASMA TAVAN", 1 },
                    { 10, "Description", "PREKAST İMALATLARI", 1 },
                    { 8, "Description", "BODRUM PERDESİ İZOLASYONU", 1 },
                    { 7, "Description", "BODRUM DRENAJ", 1 },
                    { 6, "Description", "BODRUM BETONARME", 1 },
                    { 5, "Description", "TEMEL BETONU", 1 },
                    { 4, "Description", "TEMEL MANTOLAMA", 1 },
                    { 3, "Description", "GROBETON", 1 },
                    { 9, "Description", "BETONARME İMALATI", 1 },
                    { 18, "Description", "DIŞ CEPHE TAMİRATI", 1 },
                    { 17, "Description", "İÇ SIVA ( ALÇI)", 1 },
                    { 20, "Description", "İÇ BOYA MACUNU", 1 },
                    { 35, "Description", "MERDİVEN KORKULUĞU", 1 },
                    { 34, "Description", "DIŞ BOYA", 1 },
                    { 33, "Description", "İÇ BOYA ASTARI", 1 },
                    { 32, "Description", "MENFEZ MONTAJLARI", 1 },
                    { 31, "Description", "CAM MONTAJI", 1 },
                    { 19, "Description", "PREKAST BİRLEŞİM İZOLASYONU", 1 },
                    { 29, "Description", "SERAMİK İMALATLARI", 1 },
                    { 30, "Description", "PVC DOĞRAMA MONTAJI", 1 },
                    { 27, "Description", "FAYANS İMALATI", 1 },
                    { 26, "Description", "YANGIN MERDİVEN KORKULUK", 1 },
                    { 25, "Description", "FRANSIZ BALKON KORKULUK", 1 },
                    { 24, "Description", "MERMER DENİZLİK", 1 },
                    { 23, "Description", "ŞAP + SES İZOLASYONU", 1 },
                    { 22, "Description", "DIŞ CEPHE ISI İZOLASYONU (MANTOLAMA)", 1 },
                    { 21, "Description", "KARTONPİYER", 1 },
                    { 28, "Description", "MERMER İMALATI", 1 },
                    { 38, "Description", "İÇ BOYA SON KAT", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description", "Konut Projesi" },
                    { 2, "Description", "Hidroelektrik Santral Projesi" },
                    { 3, "Description", "Hastane Projesi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBlocks_ProjectId",
                table: "ProjectBlocks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFloors_ProjectBlockId",
                table: "ProjectFloors",
                column: "ProjectBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProductionImages_ProjectProductionId",
                table: "ProjectProductionImages",
                column: "ProjectProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProductions_ProductionId",
                table: "ProjectProductions",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProductions_ProjectProductionTypeId",
                table: "ProjectProductions",
                column: "ProjectProductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProductionTypes_ProductionTypeId",
                table: "ProjectProductionTypes",
                column: "ProductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProductionTypes_ProjectFloorId",
                table: "ProjectProductionTypes",
                column: "ProjectFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompanyId",
                table: "Projects",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProjectProductionImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProjectProductions");

            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "ProjectProductionTypes");

            migrationBuilder.DropTable(
                name: "ProductionTypes");

            migrationBuilder.DropTable(
                name: "ProjectFloors");

            migrationBuilder.DropTable(
                name: "ProjectBlocks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ProjectTypes");
        }
    }
}
