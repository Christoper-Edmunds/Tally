using System.ComponentModel.DataAnnotations;

namespace Tally.Data.Entities
{
    public class FoodDatabaseFastSearch
    {
        [Key]
        public string Code { get; set; } = string.Empty;

        public string? ProductName { get; set; }
        public string? GenericName { get; set; }
        public string? Brands { get; set; }

        public DateTime? LastModifiedDatetime { get; set; }

        // Computed/concatenated search content for BM25 indexing
        // Index with: CREATE INDEX food_search_idx ON food_database_fast_search USING bm25(search_content) WITH (text_config='english');
        public string? SearchContent { get; set; }

        public FoodDatabaseSlowSearch? SlowSearchData { get; set; }

    }
}
