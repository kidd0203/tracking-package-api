A simple and powerful multi-carrier shipment tracking API that supports USPS, UPS, FedEx, DHL, LaserShip/OnTrac, Roadie, GoFor, and UniUni using a single REST endpoint.

This repository demonstrates how to use the API in C# (.NET).

🚀 Why This API?

Shipping integrations are usually complex because each carrier has:

Different APIs
Different authentication methods
Different response formats

This API solves that by providing:

✔ One API for all carriers
✔ Automatic carrier detection
✔ Unified JSON response
✔ Full tracking history
✔ Simple REST integration
✔ Free tier available

🔗 Get Started (Important)

Before using the API:

👉 Go to RapidAPI and subscribe to the Basic Plan (Free)

https://rapidapi.com/c2wtechnology/api/trackingpackage

Then open the Playground to test requests instantly in the browser.

🔑 API Endpoint
GET https://trackingpackage.p.rapidapi.com/TrackingPackage?trackingNumber={TRACKING_NUMBER}

## 📌 C# Example – Track a Package

This example shows how to call the Multi-Carrier Tracking API using C# HttpClient.
```csharp

using System;
using System.Net.Http;
using System.Threading.Tasks;


using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var trackingNumber = "9200190312809701574398";

        using var client = new HttpClient();

        // RapidAPI headers
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "YOUR_RAPIDAPI_KEY");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "trackingpackage.p.rapidapi.com");

        // API endpoint
        var url = $"https://trackingpackage.p.rapidapi.com/TrackingPackage?trackingNumber={trackingNumber}";

        // Send request
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        Console.WriteLine("Tracking API Response:");
        Console.WriteLine(content);
    }
}
```
📦 Example Response (Full JSON Schema)

The API always returns a consistent JSON structure, even when values are null or empty.

{
    "TrackingNumber": "9200190312809701574398",
    "Delivered": false,
    "Carrier": "USPS",
    "ServiceType": "USPS - USPS Ground Advantage",
    "PickupDate": "",
    "ScheduledDeliveryDate": null,
    "ScheduledDeliveryDateInDateTimeFromat": null,
    "StatusCode": "InTransit",
    "Status": "InTransit",
    "StatusSummary": "Processed through USPS Facility",
    "Message": "",
    "DeliveredDateTime": "",
    "DeliveredDateTimeInDateTimeFormat": null,
    "SignatureName": "",
    "DestinationCity": "",
    "DestinationState": "",
    "DestinationZip": "",
    "DestinationCountry": "",
    "EventDate": null,
    "ShipDate": null,
    "OriginCity": "",
    "OriginState": "",
    "OriginZip": "",
    "OriginCountry": "",
    "AccessControl": "",
    "StandardTransit": "",
    "TrackingDetails": [
        {
            "EventDateTime": "2026-07-03 02:28:00",
            "Event": "Processed through USPS Facility",
            "EventAddress": "CITY OF INDUSTRY CA DISTRIBUTION CENTER ",
            "State": null,
            "City": "CITY OF INDUSTRY CA DISTRIBUTION CENTER",
            "Zip": "",
            "EventDateTimeInDateTimeFormat": "2026-07-03T02:28:00"
        },
        {
            "EventDateTime": "2026-07-03 01:13:00",
            "Event": "Accepted at USPS Origin Facility",
            "EventAddress": "ONTARIO CA",
            "State": "CA",
            "City": "ONTARIO",
            "Zip": "",
            "EventDateTimeInDateTimeFormat": "2026-07-03T01:13:00"
        },
        {
            "EventDateTime": "2026-07-01 00:00:00",
            "Event": "Pre-Shipment Info Sent to USPS, USPS Awaiting Item",
            "EventAddress": " ",
            "State": null,
            "City": null,
            "Zip": "",
            "EventDateTimeInDateTimeFormat": "2026-07-01T00:00:00"
        }
    ]
}

📊 Supported Carriers

This API supports:

USPS
UPS
FedEx
DHL
LaserShip / OnTrac
GoFor
Roadie
UniUni
💡 Key Features
Single endpoint for all carriers
Automatic carrier detection
Normalized tracking response
Full tracking history included
Works for ecommerce & warehouse systems
Easy integration with .NET, Java, Python, JS
💰 Pricing

This API is available on RapidAPI with a free basic plan.

It is designed as a cost-effective alternative compared to platforms like:

AfterShip
TrackingMore

Ideal for developers and businesses that want:

Lower cost tracking infrastructure
Simple API integration
No complex setup
🧠 Use Cases
Ecommerce order tracking pages
Warehouse management systems (WMS)
ERP integrations
Shipping dashboards
Marketplace logistics systems
📖 Documentation

Full API documentation:

👉 https://c2wtechnology.com/tracking-api/

⭐ Repository Purpose

This repo shows how to integrate the Tracking API in C# and provides ready-to-use sample code for developers.

🤝 Feedback

If you’re using this API, feedback is welcome:

Additional carriers to support
SDK requests (C#, JS, Python, PHP)
Feature improvements
Performance suggestions
🔗 Links
API on RapidAPI: https://rapidapi.com/c2wtechnology/api/trackingpackage
Official Docs: https://c2wtechnology.com/tracking-api/

If you want next step, I can also help you make this repo even stronger by adding:

⭐ GitHub README badge section (RapidAPI, downloads, license)
⭐ Professional project structure (like real SDK repos)
⭐ OpenAPI (Swagger) file so people can auto-generate clients
⭐ A C# NuGet-style SDK wrapper (this is VERY powerful for adoption)
