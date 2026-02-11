using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tally.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodDatabaseEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Items",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoodDatabaseCode",
                table: "Items",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FoodDatabaseFastSearch",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    GenericName = table.Column<string>(type: "text", nullable: true),
                    Brands = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SearchContent = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDatabaseFastSearch", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "FoodDatabaseSlowSearch",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    Creator = table.Column<string>(type: "text", nullable: true),
                    CreatedT = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedT = table.Column<long>(type: "bigint", nullable: true),
                    LastModifiedDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedT = table.Column<long>(type: "bigint", nullable: true),
                    LastUpdatedDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    AbbreviatedProductName = table.Column<string>(type: "text", nullable: true),
                    GenericName = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<string>(type: "text", nullable: true),
                    Packaging = table.Column<string>(type: "text", nullable: true),
                    PackagingTags = table.Column<string>(type: "text", nullable: true),
                    PackagingEn = table.Column<string>(type: "text", nullable: true),
                    PackagingText = table.Column<string>(type: "text", nullable: true),
                    Brands = table.Column<string>(type: "text", nullable: true),
                    BrandsTags = table.Column<string>(type: "text", nullable: true),
                    BrandsEn = table.Column<string>(type: "text", nullable: true),
                    Categories = table.Column<string>(type: "text", nullable: true),
                    CategoriesTags = table.Column<string>(type: "text", nullable: true),
                    CategoriesEn = table.Column<string>(type: "text", nullable: true),
                    Origins = table.Column<string>(type: "text", nullable: true),
                    OriginsTags = table.Column<string>(type: "text", nullable: true),
                    OriginsEn = table.Column<string>(type: "text", nullable: true),
                    ManufacturingPlaces = table.Column<string>(type: "text", nullable: true),
                    ManufacturingPlacesTags = table.Column<string>(type: "text", nullable: true),
                    Labels = table.Column<string>(type: "text", nullable: true),
                    LabelsTags = table.Column<string>(type: "text", nullable: true),
                    LabelsEn = table.Column<string>(type: "text", nullable: true),
                    EmbCodes = table.Column<string>(type: "text", nullable: true),
                    EmbCodesTags = table.Column<string>(type: "text", nullable: true),
                    FirstPackagingCodeGeo = table.Column<string>(type: "text", nullable: true),
                    Cities = table.Column<string>(type: "text", nullable: true),
                    CitiesTags = table.Column<string>(type: "text", nullable: true),
                    PurchasePlaces = table.Column<string>(type: "text", nullable: true),
                    Stores = table.Column<string>(type: "text", nullable: true),
                    Countries = table.Column<string>(type: "text", nullable: true),
                    CountriesTags = table.Column<string>(type: "text", nullable: true),
                    CountriesEn = table.Column<string>(type: "text", nullable: true),
                    IngredientsText = table.Column<string>(type: "text", nullable: true),
                    IngredientsTags = table.Column<string>(type: "text", nullable: true),
                    IngredientsAnalysisTags = table.Column<string>(type: "text", nullable: true),
                    Allergens = table.Column<string>(type: "text", nullable: true),
                    AllergensEn = table.Column<string>(type: "text", nullable: true),
                    Traces = table.Column<string>(type: "text", nullable: true),
                    TracesTags = table.Column<string>(type: "text", nullable: true),
                    TracesEn = table.Column<string>(type: "text", nullable: true),
                    ServingSize = table.Column<string>(type: "text", nullable: true),
                    ServingQuantity = table.Column<decimal>(type: "numeric", nullable: true),
                    NoNutritionData = table.Column<string>(type: "text", nullable: true),
                    AdditivesN = table.Column<int>(type: "integer", nullable: true),
                    Additives = table.Column<string>(type: "text", nullable: true),
                    AdditivesTags = table.Column<string>(type: "text", nullable: true),
                    AdditivesEn = table.Column<string>(type: "text", nullable: true),
                    NutriscoreScore = table.Column<decimal>(type: "numeric", nullable: true),
                    NutriscoreGrade = table.Column<string>(type: "text", nullable: true),
                    NovaGroup = table.Column<int>(type: "integer", nullable: true),
                    PnnsGroups1 = table.Column<string>(type: "text", nullable: true),
                    PnnsGroups2 = table.Column<string>(type: "text", nullable: true),
                    FoodGroups = table.Column<string>(type: "text", nullable: true),
                    FoodGroupsTags = table.Column<string>(type: "text", nullable: true),
                    FoodGroupsEn = table.Column<string>(type: "text", nullable: true),
                    States = table.Column<string>(type: "text", nullable: true),
                    StatesTags = table.Column<string>(type: "text", nullable: true),
                    StatesEn = table.Column<string>(type: "text", nullable: true),
                    BrandOwner = table.Column<string>(type: "text", nullable: true),
                    EnvironmentalScoreScore = table.Column<decimal>(type: "numeric", nullable: true),
                    EnvironmentalScoreGrade = table.Column<string>(type: "text", nullable: true),
                    NutrientLevelsTags = table.Column<string>(type: "text", nullable: true),
                    ProductQuantity = table.Column<string>(type: "text", nullable: true),
                    Owner = table.Column<string>(type: "text", nullable: true),
                    DataQualityErrorsTags = table.Column<string>(type: "text", nullable: true),
                    UniqueScansN = table.Column<long>(type: "bigint", nullable: true),
                    PopularityTags = table.Column<string>(type: "text", nullable: true),
                    Completeness = table.Column<decimal>(type: "numeric", nullable: true),
                    LastImageT = table.Column<long>(type: "bigint", nullable: true),
                    LastImageDatetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MainCategory = table.Column<string>(type: "text", nullable: true),
                    MainCategoryEn = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    ImageSmallUrl = table.Column<string>(type: "text", nullable: true),
                    ImageIngredientsUrl = table.Column<string>(type: "text", nullable: true),
                    ImageIngredientsSmallUrl = table.Column<string>(type: "text", nullable: true),
                    ImageNutritionUrl = table.Column<string>(type: "text", nullable: true),
                    ImageNutritionSmallUrl = table.Column<string>(type: "text", nullable: true),
                    EnergyKj100g = table.Column<decimal>(type: "numeric", nullable: true),
                    EnergyKcal100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Energy100g = table.Column<decimal>(type: "numeric", nullable: true),
                    EnergyFromFat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Fat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    SaturatedFat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    ButyricAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CaproicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CaprylicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CapricAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    LauricAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    MyristicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    PalmiticAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    StearicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    ArachidicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    BehenicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    LignocericAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CeroticAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    MontanicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    MelissicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    UnsaturatedFat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    MonounsaturatedFat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Omega9Fat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    PolyunsaturatedFat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Omega3Fat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Omega6Fat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    AlphaLinolenicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    EicosapentaenoicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    DocosahexaenoicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    LinoleicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    ArachidonicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    GammaLinolenicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    DihomoGammaLinolenicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    OleicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    ElaidicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    GondoicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    MeadAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    ErucicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    NervonicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    TransFat100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Cholesterol100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Carbohydrates100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Sugars100g = table.Column<decimal>(type: "numeric", nullable: true),
                    AddedSugars100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Sucrose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Glucose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Fructose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Galactose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Lactose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Maltose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Maltodextrins100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Psicose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Starch100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Polyols100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Erythritol100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Isomalt100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Maltitol100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Sorbitol100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Fiber100g = table.Column<decimal>(type: "numeric", nullable: true),
                    SolubleFiber100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Polydextrose100g = table.Column<decimal>(type: "numeric", nullable: true),
                    InsolubleFiber100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Proteins100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Casein100g = table.Column<decimal>(type: "numeric", nullable: true),
                    SerumProteins100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Nucleotides100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Salt100g = table.Column<decimal>(type: "numeric", nullable: true),
                    AddedSalt100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Sodium100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Alcohol100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminA100g = table.Column<decimal>(type: "numeric", nullable: true),
                    BetaCarotene100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminD100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminE100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminK100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminC100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminB1100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminB2100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminPp100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminB6100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminB9100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Folates100g = table.Column<decimal>(type: "numeric", nullable: true),
                    VitaminB12100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Biotin100g = table.Column<decimal>(type: "numeric", nullable: true),
                    PantothenicAcid100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Silica100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Bicarbonate100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Potassium100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Chloride100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Calcium100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Phosphorus100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Iron100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Magnesium100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Zinc100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Copper100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Manganese100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Fluoride100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Selenium100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Chromium100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Molybdenum100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Iodine100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Caffeine100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Taurine100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Methylsulfonylmethane100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Ph100g = table.Column<decimal>(type: "numeric", nullable: true),
                    FruitsVegetablesNuts100g = table.Column<decimal>(type: "numeric", nullable: true),
                    FruitsVegetablesNutsDried100g = table.Column<decimal>(type: "numeric", nullable: true),
                    FruitsVegetablesNutsEstimate100g = table.Column<decimal>(type: "numeric", nullable: true),
                    FruitsVegetablesNutsEstimateFromIngredients100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CollagenMeatProteinRatio100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Cocoa100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Chlorophyl100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CarbonFootprint100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CarbonFootprintFromMeatOrFish100g = table.Column<decimal>(type: "numeric", nullable: true),
                    NutritionScoreFr100g = table.Column<decimal>(type: "numeric", nullable: true),
                    NutritionScoreUk100g = table.Column<decimal>(type: "numeric", nullable: true),
                    GlycemicIndex100g = table.Column<decimal>(type: "numeric", nullable: true),
                    WaterHardness100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Choline100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Phylloquinone100g = table.Column<decimal>(type: "numeric", nullable: true),
                    BetaGlucan100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Inositol100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Carnitine100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Sulphate100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Nitrate100g = table.Column<decimal>(type: "numeric", nullable: true),
                    Acidity100g = table.Column<decimal>(type: "numeric", nullable: true),
                    CarbohydratesTotal100g = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDatabaseSlowSearch", x => x.Code);
                    table.ForeignKey(
                        name: "FK_FoodDatabaseSlowSearch_FoodDatabaseFastSearch_Code",
                        column: x => x.Code,
                        principalTable: "FoodDatabaseFastSearch",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_Barcode",
                table: "Items",
                column: "Barcode");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FoodDatabaseCode",
                table: "Items",
                column: "FoodDatabaseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_FoodDatabaseSlowSearch_FoodDatabaseCode",
                table: "Items",
                column: "FoodDatabaseCode",
                principalTable: "FoodDatabaseSlowSearch",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_FoodDatabaseSlowSearch_FoodDatabaseCode",
                table: "Items");

            migrationBuilder.DropTable(
                name: "FoodDatabaseSlowSearch");

            migrationBuilder.DropTable(
                name: "FoodDatabaseFastSearch");

            migrationBuilder.DropIndex(
                name: "IX_Items_Barcode",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_FoodDatabaseCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "FoodDatabaseCode",
                table: "Items");
        }
    }
}
