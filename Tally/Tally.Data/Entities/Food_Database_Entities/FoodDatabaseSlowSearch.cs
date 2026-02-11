using System.ComponentModel.DataAnnotations;

namespace Tally.Data.Entities
{
    public class FoodDatabaseSlowSearch 
    {

        [Key]
        public string Code { get; set; } = string.Empty;
        public string? Url { get; set; }
        public string? Creator { get; set; }
        public long? CreatedT { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public long? LastModifiedT { get; set; }
        public DateTime? LastModifiedDatetime { get; set; }
        public string? LastModifiedBy { get; set; }
        public long? LastUpdatedT { get; set; }
        public DateTime? LastUpdatedDatetime { get; set; }

        public string? ProductName { get; set; }
        public string? AbbreviatedProductName { get; set; }
        public string? GenericName { get; set; }
        public string? Quantity { get; set; }
        public string? Packaging { get; set; }
        public string? PackagingTags { get; set; }
        public string? PackagingEn { get; set; }
        public string? PackagingText { get; set; }

        public string? Brands { get; set; }
        public string? BrandsTags { get; set; }
        public string? BrandsEn { get; set; }

        public string? Categories { get; set; }
        public string? CategoriesTags { get; set; }
        public string? CategoriesEn { get; set; }

        public string? Origins { get; set; }
        public string? OriginsTags { get; set; }
        public string? OriginsEn { get; set; }

        public string? ManufacturingPlaces { get; set; }
        public string? ManufacturingPlacesTags { get; set; }

        public string? Labels { get; set; }
        public string? LabelsTags { get; set; }
        public string? LabelsEn { get; set; }

        public string? EmbCodes { get; set; }
        public string? EmbCodesTags { get; set; }
        public string? FirstPackagingCodeGeo { get; set; }

        public string? Cities { get; set; }
        public string? CitiesTags { get; set; }
        public string? PurchasePlaces { get; set; }
        public string? Stores { get; set; }

        public string? Countries { get; set; }
        public string? CountriesTags { get; set; }
        public string? CountriesEn { get; set; }

        public string? IngredientsText { get; set; }
        public string? IngredientsTags { get; set; }
        public string? IngredientsAnalysisTags { get; set; }

        public string? Allergens { get; set; }
        public string? AllergensEn { get; set; }

        public string? Traces { get; set; }
        public string? TracesTags { get; set; }
        public string? TracesEn { get; set; }

        public string? ServingSize { get; set; }
        public decimal? ServingQuantity { get; set; }
        public string? NoNutritionData { get; set; }

        public int? AdditivesN { get; set; }
        public string? Additives { get; set; }
        public string? AdditivesTags { get; set; }
        public string? AdditivesEn { get; set; }

        public decimal? NutriscoreScore { get; set; }
        public string? NutriscoreGrade { get; set; }
        public int? NovaGroup { get; set; }

        public string? PnnsGroups1 { get; set; }
        public string? PnnsGroups2 { get; set; }
        public string? FoodGroups { get; set; }
        public string? FoodGroupsTags { get; set; }
        public string? FoodGroupsEn { get; set; }

        public string? States { get; set; }
        public string? StatesTags { get; set; }
        public string? StatesEn { get; set; }

        public string? BrandOwner { get; set; }
        public decimal? EnvironmentalScoreScore { get; set; }
        public string? EnvironmentalScoreGrade { get; set; }
        public string? NutrientLevelsTags { get; set; }
        public string? ProductQuantity { get; set; }
        public string? Owner { get; set; }
        public string? DataQualityErrorsTags { get; set; }

        public long? UniqueScansN { get; set; }
        public string? PopularityTags { get; set; }
        public decimal? Completeness { get; set; }

        public long? LastImageT { get; set; }
        public DateTime? LastImageDatetime { get; set; }

        public string? MainCategory { get; set; }
        public string? MainCategoryEn { get; set; }

        public string? ImageUrl { get; set; }
        public string? ImageSmallUrl { get; set; }
        public string? ImageIngredientsUrl { get; set; }
        public string? ImageIngredientsSmallUrl { get; set; }
        public string? ImageNutritionUrl { get; set; }
        public string? ImageNutritionSmallUrl { get; set; }

        // Nutritional values per 100g
        public decimal? EnergyKj100g { get; set; }
        public decimal? EnergyKcal100g { get; set; }
        public decimal? Energy100g { get; set; }
        public decimal? EnergyFromFat100g { get; set; }

        public decimal? Fat100g { get; set; }
        public decimal? SaturatedFat100g { get; set; }
        public decimal? ButyricAcid100g { get; set; }
        public decimal? CaproicAcid100g { get; set; }
        public decimal? CaprylicAcid100g { get; set; }
        public decimal? CapricAcid100g { get; set; }
        public decimal? LauricAcid100g { get; set; }
        public decimal? MyristicAcid100g { get; set; }
        public decimal? PalmiticAcid100g { get; set; }
        public decimal? StearicAcid100g { get; set; }
        public decimal? ArachidicAcid100g { get; set; }
        public decimal? BehenicAcid100g { get; set; }
        public decimal? LignocericAcid100g { get; set; }
        public decimal? CeroticAcid100g { get; set; }
        public decimal? MontanicAcid100g { get; set; }
        public decimal? MelissicAcid100g { get; set; }

        public decimal? UnsaturatedFat100g { get; set; }
        public decimal? MonounsaturatedFat100g { get; set; }
        public decimal? Omega9Fat100g { get; set; }
        public decimal? PolyunsaturatedFat100g { get; set; }
        public decimal? Omega3Fat100g { get; set; }
        public decimal? Omega6Fat100g { get; set; }
        public decimal? AlphaLinolenicAcid100g { get; set; }
        public decimal? EicosapentaenoicAcid100g { get; set; }
        public decimal? DocosahexaenoicAcid100g { get; set; }
        public decimal? LinoleicAcid100g { get; set; }
        public decimal? ArachidonicAcid100g { get; set; }
        public decimal? GammaLinolenicAcid100g { get; set; }
        public decimal? DihomoGammaLinolenicAcid100g { get; set; }
        public decimal? OleicAcid100g { get; set; }
        public decimal? ElaidicAcid100g { get; set; }
        public decimal? GondoicAcid100g { get; set; }
        public decimal? MeadAcid100g { get; set; }
        public decimal? ErucicAcid100g { get; set; }
        public decimal? NervonicAcid100g { get; set; }

        public decimal? TransFat100g { get; set; }
        public decimal? Cholesterol100g { get; set; }

        public decimal? Carbohydrates100g { get; set; }
        public decimal? Sugars100g { get; set; }
        public decimal? AddedSugars100g { get; set; }
        public decimal? Sucrose100g { get; set; }
        public decimal? Glucose100g { get; set; }
        public decimal? Fructose100g { get; set; }
        public decimal? Galactose100g { get; set; }
        public decimal? Lactose100g { get; set; }
        public decimal? Maltose100g { get; set; }
        public decimal? Maltodextrins100g { get; set; }
        public decimal? Psicose100g { get; set; }
        public decimal? Starch100g { get; set; }
        public decimal? Polyols100g { get; set; }
        public decimal? Erythritol100g { get; set; }
        public decimal? Isomalt100g { get; set; }
        public decimal? Maltitol100g { get; set; }
        public decimal? Sorbitol100g { get; set; }

        public decimal? Fiber100g { get; set; }
        public decimal? SolubleFiber100g { get; set; }
        public decimal? Polydextrose100g { get; set; }
        public decimal? InsolubleFiber100g { get; set; }

        public decimal? Proteins100g { get; set; }
        public decimal? Casein100g { get; set; }
        public decimal? SerumProteins100g { get; set; }
        public decimal? Nucleotides100g { get; set; }

        public decimal? Salt100g { get; set; }
        public decimal? AddedSalt100g { get; set; }
        public decimal? Sodium100g { get; set; }
        public decimal? Alcohol100g { get; set; }

        // Vitamins
        public decimal? VitaminA100g { get; set; }
        public decimal? BetaCarotene100g { get; set; }
        public decimal? VitaminD100g { get; set; }
        public decimal? VitaminE100g { get; set; }
        public decimal? VitaminK100g { get; set; }
        public decimal? VitaminC100g { get; set; }
        public decimal? VitaminB1100g { get; set; }
        public decimal? VitaminB2100g { get; set; }
        public decimal? VitaminPp100g { get; set; }
        public decimal? VitaminB6100g { get; set; }
        public decimal? VitaminB9100g { get; set; }
        public decimal? Folates100g { get; set; }
        public decimal? VitaminB12100g { get; set; }
        public decimal? Biotin100g { get; set; }
        public decimal? PantothenicAcid100g { get; set; }

        // Minerals
        public decimal? Silica100g { get; set; }
        public decimal? Bicarbonate100g { get; set; }
        public decimal? Potassium100g { get; set; }
        public decimal? Chloride100g { get; set; }
        public decimal? Calcium100g { get; set; }
        public decimal? Phosphorus100g { get; set; }
        public decimal? Iron100g { get; set; }
        public decimal? Magnesium100g { get; set; }
        public decimal? Zinc100g { get; set; }
        public decimal? Copper100g { get; set; }
        public decimal? Manganese100g { get; set; }
        public decimal? Fluoride100g { get; set; }
        public decimal? Selenium100g { get; set; }
        public decimal? Chromium100g { get; set; }
        public decimal? Molybdenum100g { get; set; }
        public decimal? Iodine100g { get; set; }

        // Other compounds
        public decimal? Caffeine100g { get; set; }
        public decimal? Taurine100g { get; set; }
        public decimal? Methylsulfonylmethane100g { get; set; }
        public decimal? Ph100g { get; set; }

        // Fruit/vegetable content
        public decimal? FruitsVegetablesNuts100g { get; set; }
        public decimal? FruitsVegetablesNutsDried100g { get; set; }
        public decimal? FruitsVegetablesNutsEstimate100g { get; set; }
        public decimal? FruitsVegetablesNutsEstimateFromIngredients100g { get; set; }

        // Other metrics
        public decimal? CollagenMeatProteinRatio100g { get; set; }
        public decimal? Cocoa100g { get; set; }
        public decimal? Chlorophyl100g { get; set; }
        public decimal? CarbonFootprint100g { get; set; }
        public decimal? CarbonFootprintFromMeatOrFish100g { get; set; }
        public decimal? NutritionScoreFr100g { get; set; }
        public decimal? NutritionScoreUk100g { get; set; }
        public decimal? GlycemicIndex100g { get; set; }
        public decimal? WaterHardness100g { get; set; }
        public decimal? Choline100g { get; set; }
        public decimal? Phylloquinone100g { get; set; }
        public decimal? BetaGlucan100g { get; set; }
        public decimal? Inositol100g { get; set; }
        public decimal? Carnitine100g { get; set; }
        public decimal? Sulphate100g { get; set; }
        public decimal? Nitrate100g { get; set; }
        public decimal? Acidity100g { get; set; }
        public decimal? CarbohydratesTotal100g { get; set; }

        public FoodDatabaseFastSearch? FastSearchData { get; set; }
    }
}
