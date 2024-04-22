using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Unity.Google.Maps.Directions
{
    public class DirectionsResponse
    {
        [JsonProperty("routes")] 
        public List<DirectionsRoute> Routes { get; set; }
        
        [JsonProperty("status")] 
        public string Status { get; set; }

        [JsonProperty("available_travel_modes")]
        public List<string> AvailableTravelModes { get; set; }
        
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
        
        [JsonProperty("geocoded_waypoints")] 
        public List<DirectionsGeocodedWaypoint> DirectionsGeocodedWaypoint { get; set; }
        
    }

    public class DirectionsGeocodedWaypoint
    {
        [JsonProperty("geocoder_status")] 
        public string GeocoderStatus { get; set; }
        
        [JsonProperty("place_id")] 
        public string PlaceID { get; set; }
        
        [JsonProperty("types")] 
        public List<string> Types { get; set; }
    }

    public class DirectionsRoute
    {
        [JsonProperty("bounds")] 
        public Bounds Bounds { get; set; }
        
        [JsonProperty("copyrights")] 
        public string Copyrights { get; set; }
        
        [JsonProperty("legs")] 
        public List<DirectionsLeg> Legs { get; set; }
        
        [JsonProperty("overview_polyline")] 
        public DirectionsPolyline OverveiwPolyline { get; set; }
        
        [JsonProperty("summary")] 
        public string Summary { get; set; }
        
        [JsonProperty("warnings")] 
        public List<string> Warnings { get; set; }
        
        [JsonProperty("waypoint_order")] 
        public List<int> WaypointOrder { get; set; }
        
        [JsonProperty("fare")] 
        public Fare Fare { get; set; }

    }

    public class Bounds
    {
        [JsonProperty("northeast")] 
        public LatLngLiteral NorthEast { get; set; }
        
        [JsonProperty("southwest")] 
        public LatLngLiteral SouthWest { get; set; }
    }
    
    public class LatLngLiteral
    {
        [JsonProperty("lat")] 
        public double Lat { get; set; }
        
        [JsonProperty("lng")] 
        public double Lng { get; set; }
    }
    
    public class DirectionsLeg
    {
        [JsonProperty("end_address")] 
        public string EndAddress { get; set; }
        
        [JsonProperty("end_location")] 
        public LatLngLiteral EndLocation { get; set; }
        
        [JsonProperty("start_address")] 
        public string StartAddress { get; set; }
        
        [JsonProperty("start_location")] 
        public LatLngLiteral StartLocation { get; set; }
        
        [JsonProperty("steps")] 
        public List<DirectionsStep> Steps  { get; set; }
        
        [JsonProperty("via_waypoint")] 
        public List<DirectionsViaWaypoint> ViaWaypoint  { get; set; }
        
        [JsonProperty("arrival_time")] 
        public TimeZoneTextValueObject ArrivalTime { get; set; }

        [JsonProperty("departure_time")]
        public TimeZoneTextValueObject DepartureTime { get; set; }
        
        [JsonProperty("distance")]
        public TextValueObject Distance { get; set; }
        
        [JsonProperty("duration")]
        public TextValueObject Duration { get; set; }
        
        [JsonProperty("duration_in_traffic")]
        public TextValueObject DurationInTraffic { get; set; }
    }
    
    public class DirectionsStep
    {
        [JsonProperty("duration")] 
        public TextValueObject Duration { get; set; }
        
        [JsonProperty("end_location")]
        public LatLngLiteral EndLocation { get; set; }
        
        [JsonProperty("html_instructions")]
        public string HtmlInstructions { get; set; }
        
        [JsonProperty("polyline")]
        public DirectionsPolyline Polyline { get; set; }
        
        [JsonProperty("start_location")]
        public LatLngLiteral StartLocation { get; set; }
        
        [JsonProperty("travel_mode")]
        public string TravelMode { get; set; }
        
        [JsonProperty("distance")]
        public TextValueObject Distance { get; set; }
        
        [JsonProperty("maneuver")]
        public string Maneuver { get; set; }
        
        //public string Steps = "";
        [JsonProperty("transit_details")]
        public DirectionsTransitDetails TransitDetails;
    }   
    
    public class TextValueObject
    {
        [JsonProperty("text")] 
        public string Text { get; set; }
        
        [JsonProperty("value")]
        public int Value { get; set; }
        
    }
    
    public class DirectionsPolyline
    {
        [JsonProperty("points")]
        public string points { get; set; }
    }
    
    public class DirectionsTransitDetails
    {
        [JsonProperty("arrival_stop")]
        public DirectionsTransitStop ArrivalStop { get; set; }
        
        [JsonProperty("arrival_time")]
        public TimeZoneTextValueObject ArrivalTime { get; set; }
        
        [JsonProperty("departure_stop")]
        public DirectionsTransitStop DepartureStop { get; set; }
        
        [JsonProperty("departure_time")]
        public TimeZoneTextValueObject DepartureTime { get; set; }
        
        [JsonProperty("headsign")]
        public string HeadSign { get; set; }
        
        [JsonProperty("headway")]
        public int Headway { get; set; }
        
        [JsonProperty("line")]
        public DirectionsTransitLine Line { get; set; }
        
        [JsonProperty("num_stops")]
        public int NumberOfStops { get; set; }
        
        [JsonProperty("trip_short_name")]
        public string TripShortName { get; set; }

    }
    
    public class DirectionsTransitStop
    {
        [JsonProperty("location")] 
        public LatLngLiteral Location { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }
    
    }
    
    public class DirectionsViaWaypoint
    {
        [JsonProperty("location")] 
        public LatLngLiteral Location { get; set; }
        
        [JsonProperty("step_index")] 
        public int StepIndex { get; set; }
        
        [JsonProperty("step_interpolation")] 
        public double StepInterpolation { get; set; }
    }

    [Serializable]
    public class TimeZoneTextValueObject
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        
        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }
        
        [JsonProperty("value")]
        public double Value {get; set; }
    }
    
    public class DirectionsTransitAgency
    {
        [JsonProperty("name")]
        public string Name {get; set; }
        
        [JsonProperty("phone")]
        public string Phone {get; set; }
        
        [JsonProperty("url")]
        public string Url {get; set; }
    }

    public class DirectionsTransitLine
    {
        [JsonProperty("agencies")]
        public List<DirectionsTransitAgency> Agencies { get; set; }
        
        [JsonProperty("name")] 
        public string Name { get; set; }
        
        [JsonProperty("color")] 
        public string Color { get; set; }
        
        [JsonProperty("icon")]
        public string Icon { get; set; }
        
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        
        [JsonProperty("text_color")]
        public string TextColor { get; set; }
        
        [JsonProperty("url")]
        public string Url { get; set; }
        
        [JsonProperty("vehicle")]
        public DirectionsTransitVehicle Vehicle { get; set; }
    }
    
    public class DirectionsTransitVehicle
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("icon")] 
        public string Icon { get; set; }
        
        [JsonProperty("local_icon")]
        public string LocalIcon { get; set; }
    }

    [Serializable]
    public class Fare
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        [JsonProperty("text")]
        public string Text { get; set; }
        
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
