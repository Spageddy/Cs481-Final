using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Final1.Models
{
    public partial class TicketMaster
    {
        [JsonProperty("_embedded")]
        public TicketMasterEmbedded Embedded { get; set; }

        [JsonProperty("_links")]
        public TicketMasterLinks Links { get; set; }

        [JsonProperty("page")]
        public Page Page { get; set; }
    }

    public partial class TicketMasterEmbedded
    {
        [JsonProperty("events")]
        public List<Event> Events { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("sales")]
        public Sales Sales { get; set; }

        [JsonProperty("dates")]
        public Dates Dates { get; set; }

        [JsonProperty("classifications")]
        public List<Classification> Classifications { get; set; }

        [JsonProperty("promoter")]
        public Promoter Promoter { get; set; }

        [JsonProperty("promoters")]
        public List<Promoter> Promoters { get; set; }

        [JsonProperty("products")]
        public List<Product> Products { get; set; }

        [JsonProperty("seatmap")]
        public Seatmap Seatmap { get; set; }

        [JsonProperty("accessibility")]
        public Accessibility Accessibility { get; set; }

        [JsonProperty("ticketLimit")]
        public Accessibility TicketLimit { get; set; }

        [JsonProperty("_links")]
        public EventLinks Links { get; set; }

        [JsonProperty("_embedded")]
        public EventEmbedded Embedded { get; set; }
    }

    public partial class Accessibility
    {
        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public partial class Classification
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("segment")]
        public Genre Segment { get; set; }

        [JsonProperty("genre")]
        public Genre Genre { get; set; }

        [JsonProperty("subGenre")]
        public Genre SubGenre { get; set; }

        [JsonProperty("type")]
        public Genre Type { get; set; }

        [JsonProperty("subType")]
        public Genre SubType { get; set; }

        [JsonProperty("family")]
        public bool Family { get; set; }
    }

    public partial class Genre
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Dates
    {
        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("spanMultipleDays")]
        public bool SpanMultipleDays { get; set; }
    }

    public partial class Start
    {
        [JsonProperty("localDate")]
        public DateTimeOffset LocalDate { get; set; }

        [JsonProperty("localTime")]
        public DateTimeOffset LocalTime { get; set; }

        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("dateTBD")]
        public bool DateTbd { get; set; }

        [JsonProperty("dateTBA")]
        public bool DateTba { get; set; }

        [JsonProperty("timeTBA")]
        public bool TimeTba { get; set; }

        [JsonProperty("noSpecificTime")]
        public bool NoSpecificTime { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public partial class EventEmbedded
    {
        [JsonProperty("venues")]
        public List<Venue> Venues { get; set; }

        [JsonProperty("attractions")]
        public List<Attraction> Attractions { get; set; }
    }

    public partial class Attraction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("classifications")]
        public List<Classification> Classifications { get; set; }

        [JsonProperty("upcomingEvents")]
        public UpcomingEvents UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public AttractionLinks Links { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("fallback")]
        public bool Fallback { get; set; }
    }

    public partial class AttractionLinks
    {
        [JsonProperty("self")]
        public First Self { get; set; }
    }

    public partial class First
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public partial class UpcomingEvents
    {
        [JsonProperty("_total")]
        public long Total { get; set; }

        [JsonProperty("tmr", NullValueHandling = NullValueHandling.Ignore)]
        public long? Tmr { get; set; }

        [JsonProperty("ticketmaster")]
        public long Ticketmaster { get; set; }
    }

    public partial class Venue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("postalCode")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PostalCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("markets")]
        public List<Genre> Markets { get; set; }

        [JsonProperty("dmas")]
        public List<Dma> Dmas { get; set; }

        [JsonProperty("boxOfficeInfo")]
        public BoxOfficeInfo BoxOfficeInfo { get; set; }

        [JsonProperty("parkingDetail")]
        public string ParkingDetail { get; set; }

        [JsonProperty("accessibleSeatingDetail")]
        public string AccessibleSeatingDetail { get; set; }

        [JsonProperty("generalInfo")]
        public GeneralInfo GeneralInfo { get; set; }

        [JsonProperty("upcomingEvents")]
        public UpcomingEvents UpcomingEvents { get; set; }

        [JsonProperty("_links")]
        public AttractionLinks Links { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }
    }

    public partial class BoxOfficeInfo
    {
        [JsonProperty("phoneNumberDetail")]
        public string PhoneNumberDetail { get; set; }

        [JsonProperty("openHoursDetail")]
        public string OpenHoursDetail { get; set; }

        [JsonProperty("willCallDetail")]
        public string WillCallDetail { get; set; }
    }

    public partial class City
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public partial class Dma
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class GeneralInfo
    {
        [JsonProperty("childRule")]
        public string ChildRule { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    public partial class State
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public partial class EventLinks
    {
        [JsonProperty("self")]
        public First Self { get; set; }

        [JsonProperty("attractions")]
        public List<First> Attractions { get; set; }

        [JsonProperty("venues")]
        public List<First> Venues { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Promoter
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Sales
    {
        [JsonProperty("public")]
        public Public Public { get; set; }

        [JsonProperty("presales")]
        public List<Presale> Presales { get; set; }
    }

    public partial class Presale
    {
        [JsonProperty("startDateTime")]
        public DateTimeOffset StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public DateTimeOffset EndDateTime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Public
    {
        [JsonProperty("startDateTime")]
        public DateTimeOffset StartDateTime { get; set; }

        [JsonProperty("startTBD")]
        public bool StartTbd { get; set; }

        [JsonProperty("endDateTime")]
        public DateTimeOffset EndDateTime { get; set; }
    }

    public partial class Seatmap
    {
        [JsonProperty("staticUrl")]
        public Uri StaticUrl { get; set; }
    }

    public partial class TicketMasterLinks
    {
        [JsonProperty("first")]
        public First First { get; set; }

        [JsonProperty("prev")]
        public First Prev { get; set; }

        [JsonProperty("self")]
        public First Self { get; set; }

        [JsonProperty("next")]
        public First Next { get; set; }

        [JsonProperty("last")]
        public First Last { get; set; }
    }

    public partial class Page
    {
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }

    public enum Ratio { The16_9, The3_2, The4_3 };

    public partial class TicketMaster
    {
        public static TicketMaster FromJson(string json) => JsonConvert.DeserializeObject<TicketMaster>(json, Final1.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TicketMaster self) => JsonConvert.SerializeObject(self, Final1.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                RatioConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class RatioConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ratio) || t == typeof(Ratio?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "16_9":
                    return Ratio.The16_9;
                case "3_2":
                    return Ratio.The3_2;
                case "4_3":
                    return Ratio.The4_3;
            }
            throw new Exception("Cannot unmarshal type Ratio");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Ratio)untypedValue;
            switch (value)
            {
                case Ratio.The16_9:
                    serializer.Serialize(writer, "16_9");
                    return;
                case Ratio.The3_2:
                    serializer.Serialize(writer, "3_2");
                    return;
                case Ratio.The4_3:
                    serializer.Serialize(writer, "4_3");
                    return;
            }
            throw new Exception("Cannot marshal type Ratio");
        }

        public static readonly RatioConverter Singleton = new RatioConverter();
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
}
