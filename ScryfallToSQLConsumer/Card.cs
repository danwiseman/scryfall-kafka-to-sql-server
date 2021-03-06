// Generated by https://quicktype.io

namespace ScryfallToSQLConsumer
{

    using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class Card
        {
            [JsonProperty("object")] public string Object { get; set; }

            [JsonProperty("id")] public Guid Id { get; set; }

            [JsonProperty("oracle_id")] public Guid OracleId { get; set; }

            [JsonProperty("multiverse_ids")] public long[] MultiverseIds { get; set; }

            [JsonProperty("mtgo_id")] public long MtgoId { get; set; }

            [JsonProperty("mtgo_foil_id")] public long MtgoFoilId { get; set; }

            [JsonProperty("tcgplayer_id")] public long TcgplayerId { get; set; }

            [JsonProperty("cardmarket_id")] public long CardmarketId { get; set; }

            [JsonProperty("name")] public string Name { get; set; }

            [JsonProperty("lang")] public string Lang { get; set; }

            [JsonProperty("released_at")] public DateTimeOffset ReleasedAt { get; set; }

            [JsonProperty("uri")] public Uri Uri { get; set; }

            [JsonProperty("scryfall_uri")] public Uri ScryfallUri { get; set; }

            [JsonProperty("layout")] public string Layout { get; set; }

            [JsonProperty("highres_image")] public bool HighresImage { get; set; }

            [JsonProperty("image_status")] public string ImageStatus { get; set; }

            [JsonProperty("cmc")] public double Cmc { get; set; }

            [JsonProperty("type_line")] public string TypeLine { get; set; }

            [JsonProperty("color_identity")] public string[] ColorIdentity { get; set; }

            [JsonProperty("keywords")] public string[] Keywords { get; set; }

            [JsonProperty("card_faces")] public CardFace[] CardFaces { get; set; }

            [JsonProperty("legalities")] public Dictionary<string, Legality> Legalities { get; set; }

            [JsonProperty("games")] public string[] Games { get; set; }

            [JsonProperty("reserved")] public bool Reserved { get; set; }

            [JsonProperty("foil")] public bool Foil { get; set; }

            [JsonProperty("nonfoil")] public bool Nonfoil { get; set; }

            [JsonProperty("finishes")] public string[] Finishes { get; set; }

            [JsonProperty("oversized")] public bool Oversized { get; set; }

            [JsonProperty("promo")] public bool Promo { get; set; }

            [JsonProperty("reprint")] public bool Reprint { get; set; }

            [JsonProperty("variation")] public bool Variation { get; set; }

            [JsonProperty("set_id")] public Guid SetId { get; set; }

            [JsonProperty("set")] public string Set { get; set; }

            [JsonProperty("set_name")] public string SetName { get; set; }

            [JsonProperty("set_type")] public string SetType { get; set; }

            [JsonProperty("set_uri")] public Uri SetUri { get; set; }

            [JsonProperty("set_search_uri")] public Uri SetSearchUri { get; set; }

            [JsonProperty("scryfall_set_uri")] public Uri ScryfallSetUri { get; set; }

            [JsonProperty("rulings_uri")] public Uri RulingsUri { get; set; }

            [JsonProperty("prints_search_uri")] public Uri PrintsSearchUri { get; set; }

            [JsonProperty("collector_number")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CollectorNumber { get; set; }

            [JsonProperty("digital")] public bool Digital { get; set; }

            [JsonProperty("rarity")] public string Rarity { get; set; }

            [JsonProperty("artist")] public string Artist { get; set; }

            [JsonProperty("artist_ids")] public Guid[] ArtistIds { get; set; }

            [JsonProperty("border_color")] public string BorderColor { get; set; }

            [JsonProperty("frame")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Frame { get; set; }

            [JsonProperty("frame_effects")] public string[] FrameEffects { get; set; }

            [JsonProperty("full_art")] public bool FullArt { get; set; }

            [JsonProperty("textless")] public bool Textless { get; set; }

            [JsonProperty("booster")] public bool Booster { get; set; }

            [JsonProperty("story_spotlight")] public bool StorySpotlight { get; set; }

            [JsonProperty("edhrec_rank")] public long EdhrecRank { get; set; }

            [JsonProperty("prices")] public Dictionary<string, string> Prices { get; set; }

            [JsonProperty("related_uris")] public RelatedUris RelatedUris { get; set; }

            [JsonProperty("purchase_uris")] public PurchaseUris PurchaseUris { get; set; }
        }

        public partial class CardFace
        {
            [JsonProperty("object")] public string Object { get; set; }

            [JsonProperty("name")] public string Name { get; set; }

            [JsonProperty("mana_cost")] public string ManaCost { get; set; }

            [JsonProperty("type_line")] public string TypeLine { get; set; }

            [JsonProperty("oracle_text")] public string OracleText { get; set; }

            [JsonProperty("colors")] public string[] Colors { get; set; }

            [JsonProperty("power")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Power { get; set; }

            [JsonProperty("toughness")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Toughness { get; set; }

            [JsonProperty("flavor_text", NullValueHandling = NullValueHandling.Ignore)]
            public string FlavorText { get; set; }

            [JsonProperty("artist")] public string Artist { get; set; }

            [JsonProperty("artist_id")] public Guid ArtistId { get; set; }

            [JsonProperty("illustration_id")] public Guid IllustrationId { get; set; }

            [JsonProperty("image_uris")] public ImageUris ImageUris { get; set; }

            [JsonProperty("flavor_name", NullValueHandling = NullValueHandling.Ignore)]
            public string FlavorName { get; set; }

            [JsonProperty("color_indicator", NullValueHandling = NullValueHandling.Ignore)]
            public string[] ColorIndicator { get; set; }
        }

        public partial class ImageUris
        {
            [JsonProperty("small")] public Uri Small { get; set; }

            [JsonProperty("normal")] public Uri Normal { get; set; }

            [JsonProperty("large")] public Uri Large { get; set; }

            [JsonProperty("png")] public Uri Png { get; set; }

            [JsonProperty("art_crop")] public Uri ArtCrop { get; set; }

            [JsonProperty("border_crop")] public Uri BorderCrop { get; set; }
        }

        public partial class PurchaseUris
        {
            [JsonProperty("tcgplayer")] public Uri Tcgplayer { get; set; }

            [JsonProperty("cardmarket")] public Uri Cardmarket { get; set; }

            [JsonProperty("cardhoarder")] public Uri Cardhoarder { get; set; }
        }

        public partial class RelatedUris
        {
            [JsonProperty("gatherer")] public Uri Gatherer { get; set; }

            [JsonProperty("tcgplayer_infinite_articles")]
            public Uri TcgplayerInfiniteArticles { get; set; }

            [JsonProperty("tcgplayer_infinite_decks")]
            public Uri TcgplayerInfiniteDecks { get; set; }

            [JsonProperty("edhrec")] public Uri Edhrec { get; set; }

            [JsonProperty("mtgtop8")] public Uri Mtgtop8 { get; set; }
        }

        public enum Legality
        {
            Legal,
            NotLegal,
            Restricted
        };

        public partial class Card
        {
            public static Card FromJson(string json) =>
                JsonConvert.DeserializeObject<Card>(json, Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Card self) =>
                JsonConvert.SerializeObject(self, Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    LegalityConverter.Singleton,
                    new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
                },
            };
        }

        internal class ParseStringConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                long l;
                if (Int64.TryParse(value, out l))
                {
                    return l;
                }

                throw new Exception("Cannot unmarshal type long");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }

                var value = (long) untypedValue;
                serializer.Serialize(writer, value.ToString());
                return;
            }

            public static readonly ParseStringConverter Singleton = new ParseStringConverter();
        }

        internal class LegalityConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Legality) || t == typeof(Legality?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "legal":
                        return Legality.Legal;
                    case "not_legal":
                        return Legality.NotLegal;
                    case "restricted":
                        return Legality.Restricted;
                }

                throw new Exception("Cannot unmarshal type Legality");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }

                var value = (Legality) untypedValue;
                switch (value)
                {
                    case Legality.Legal:
                        serializer.Serialize(writer, "legal");
                        return;
                    case Legality.NotLegal:
                        serializer.Serialize(writer, "not_legal");
                        return;
                    case Legality.Restricted:
                        serializer.Serialize(writer, "restricted");
                        return;
                }

                throw new Exception("Cannot marshal type Legality");
            }

            public static readonly LegalityConverter Singleton = new LegalityConverter();
        }
    }
