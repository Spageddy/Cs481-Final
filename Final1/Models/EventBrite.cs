using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Final1.Models
{
    public partial class EventBrite
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("name")]
        public Description Name { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("start")]
        public End Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("changed")]
        public DateTimeOffset Changed { get; set; }

        [JsonProperty("published")]
        public DateTimeOffset Published { get; set; }

        [JsonProperty("capacity")]
        public object Capacity { get; set; }

        [JsonProperty("capacity_is_custom")]
        public object CapacityIsCustom { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("listed")]
        public bool Listed { get; set; }

        [JsonProperty("shareable")]
        public bool Shareable { get; set; }

        [JsonProperty("online_event")]
        public bool OnlineEvent { get; set; }

        [JsonProperty("tx_time_limit")]
        public long TxTimeLimit { get; set; }

        [JsonProperty("hide_start_date")]
        public bool HideStartDate { get; set; }

        [JsonProperty("hide_end_date")]
        public bool HideEndDate { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("privacy_setting")]
        public PrivacySetting PrivacySetting { get; set; }

        [JsonProperty("is_series")]
        public bool IsSeries { get; set; }

        [JsonProperty("is_series_parent")]
        public bool IsSeriesParent { get; set; }

        [JsonProperty("inventory_type")]
        public string InventoryType { get; set; }

        [JsonProperty("is_reserved_seating")]
        public bool IsReservedSeating { get; set; }

        [JsonProperty("show_pick_a_seat")]
        public bool ShowPickASeat { get; set; }

        [JsonProperty("show_seatmap_thumbnail")]
        public bool ShowSeatmapThumbnail { get; set; }

        [JsonProperty("show_colors_in_seatmap_thumbnail")]
        public bool ShowColorsInSeatmapThumbnail { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("is_free")]
        public bool IsFree { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("logo_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long LogoId { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("venue_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long VenueId { get; set; }

        [JsonProperty("category_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? CategoryId { get; set; }

        [JsonProperty("subcategory_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? SubcategoryId { get; set; }

        [JsonProperty("format_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long FormatId { get; set; }

        [JsonProperty("resource_uri")]
        public Uri ResourceUri { get; set; }

        [JsonProperty("is_externally_ticketed")]
        public bool IsExternallyTicketed { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("vanity_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri VanityUrl { get; set; }

        [JsonProperty("series_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SeriesId { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }

    public partial class End
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("local")]
        public DateTimeOffset Local { get; set; }

        [JsonProperty("utc")]
        public DateTimeOffset Utc { get; set; }
    }

    public partial class Logo
    {
        [JsonProperty("crop_mask")]
        public CropMask CropMask { get; set; }

        [JsonProperty("original")]
        public Original Original { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("aspect_ratio")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AspectRatio { get; set; }

        [JsonProperty("edge_color")]
        public string EdgeColor { get; set; }

        [JsonProperty("edge_color_set")]
        public bool EdgeColorSet { get; set; }
    }

    public partial class CropMask
    {
        [JsonProperty("top_left")]
        public TopLeft TopLeft { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }

    public partial class TopLeft
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }
    }

    public partial class Original
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("within")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Within { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public partial class Pagination
    {
        [JsonProperty("object_count")]
        public long ObjectCount { get; set; }

        [JsonProperty("page_number")]
        public long PageNumber { get; set; }

        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        [JsonProperty("page_count")]
        public long PageCount { get; set; }

        [JsonProperty("has_more_items")]
        public bool HasMoreItems { get; set; }
    }

    public enum Currency { Usd };

    public enum Timezone { AmericaLosAngeles };

    public enum InventoryType { Limited };

    public enum Locale { EnUs };

    public enum PrivacySetting { Unlocked };

    public enum Source { Coyote, Create20 };

    public enum Status { Live, Started };

    public enum Version { The300, The370 };

    public partial class EventBrite
    {
        public static EventBrite FromJson(string json) => JsonConvert.DeserializeObject<EventBrite>(json, Final1.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this EventBrite self) => JsonConvert.SerializeObject(self, Final1.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CurrencyConverter.Singleton,
                TimezoneConverter.Singleton,
                InventoryTypeConverter.Singleton,
                LocaleConverter.Singleton,
                PrivacySettingConverter.Singleton,
                SourceConverter.Singleton,
                StatusConverter.Singleton,
                VersionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
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
            //throw new Exception("Cannot unmarshal type long");
            return l;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class CurrencyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Currency) || t == typeof(Currency?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USD")
            {
                return Currency.Usd;
            }
            throw new Exception("Cannot unmarshal type Currency");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Currency)untypedValue;
            if (value == Currency.Usd)
            {
                serializer.Serialize(writer, "USD");
                return;
            }
            throw new Exception("Cannot marshal type Currency");
        }

        public static readonly CurrencyConverter Singleton = new CurrencyConverter();
    }

    internal class TimezoneConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Timezone) || t == typeof(Timezone?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "America/Los_Angeles")
            {
                return Timezone.AmericaLosAngeles;
            }
            throw new Exception("Cannot unmarshal type Timezone");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Timezone)untypedValue;
            if (value == Timezone.AmericaLosAngeles)
            {
                serializer.Serialize(writer, "America/Los_Angeles");
                return;
            }
            throw new Exception("Cannot marshal type Timezone");
        }

        public static readonly TimezoneConverter Singleton = new TimezoneConverter();
    }

    internal class InventoryTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(InventoryType) || t == typeof(InventoryType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "limited")
            {
                return InventoryType.Limited;
            }
            throw new Exception("Cannot unmarshal type InventoryType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (InventoryType)untypedValue;
            if (value == InventoryType.Limited)
            {
                serializer.Serialize(writer, "limited");
                return;
            }
            throw new Exception("Cannot marshal type InventoryType");
        }

        public static readonly InventoryTypeConverter Singleton = new InventoryTypeConverter();
    }

    internal class LocaleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Locale) || t == typeof(Locale?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "en_US")
            {
                return Locale.EnUs;
            }
            throw new Exception("Cannot unmarshal type Locale");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Locale)untypedValue;
            if (value == Locale.EnUs)
            {
                serializer.Serialize(writer, "en_US");
                return;
            }
            throw new Exception("Cannot marshal type Locale");
        }

        public static readonly LocaleConverter Singleton = new LocaleConverter();
    }

    internal class PrivacySettingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PrivacySetting) || t == typeof(PrivacySetting?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "unlocked")
            {
                return PrivacySetting.Unlocked;
            }
            throw new Exception("Cannot unmarshal type PrivacySetting");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PrivacySetting)untypedValue;
            if (value == PrivacySetting.Unlocked)
            {
                serializer.Serialize(writer, "unlocked");
                return;
            }
            throw new Exception("Cannot marshal type PrivacySetting");
        }

        public static readonly PrivacySettingConverter Singleton = new PrivacySettingConverter();
    }

    internal class SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Source) || t == typeof(Source?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "coyote":
                    return Source.Coyote;
                case "create_2.0":
                    return Source.Create20;
            }
            throw new Exception("Cannot unmarshal type Source");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Source)untypedValue;
            switch (value)
            {
                case Source.Coyote:
                    serializer.Serialize(writer, "coyote");
                    return;
                case Source.Create20:
                    serializer.Serialize(writer, "create_2.0");
                    return;
            }
            throw new Exception("Cannot marshal type Source");
        }

        public static readonly SourceConverter Singleton = new SourceConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "live":
                    return Status.Live;
                case "started":
                    return Status.Started;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Live:
                    serializer.Serialize(writer, "live");
                    return;
                case Status.Started:
                    serializer.Serialize(writer, "started");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class VersionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Version) || t == typeof(Version?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "3.0.0":
                    return Version.The300;
                case "3.7.0":
                    return Version.The370;
            }
            throw new Exception("Cannot unmarshal type Version");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Version)untypedValue;
            switch (value)
            {
                case Version.The300:
                    serializer.Serialize(writer, "3.0.0");
                    return;
                case Version.The370:
                    serializer.Serialize(writer, "3.7.0");
                    return;
            }
            throw new Exception("Cannot marshal type Version");
        }

        public static readonly VersionConverter Singleton = new VersionConverter();
    }
}
