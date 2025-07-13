# Weather Service

This project is a simple service that gets current weather info from the OpenWeather API. It uses .NET and talks to the API with an HttpClient.

---

## What it does

- Gets weather for a given latitude and longitude
- Returns temperature and weather description
- Uses settings you provide like API key and units (metric, imperial, etc)
- Has tests to make sure it works properly

---

## What you need

- .NET 6 or newer
- An internet connection (to reach OpenWeather)
- Your own OpenWeather API key

---

## How to set it up

The service uses options to configure the API call. Here’s what you need to set:

- Base URL (usually `https://api.openweathermap.org`)
- Latitude and Longitude for the location you want
- Your API key from OpenWeather
- Units for temperature (like `"metric"`)

---

## How to use it
- Run the solution 
- It will call the service like this:

```csharp
var weather = await weatherService.RetreiveWeatherAsnc();

Console.WriteLine($"City: {weather.Name}, Temp: {weather.Main.Temp}°C");

# Unit Tests

This project has a separate test project that checks if the main code works correctly.

---

## How to run the tests

1. Open the test project in Visual Studio.
2. Go to **Test > Test Explorer**.
3. Run all the tests.

---

## What the tests check

- Creating a book  
- Getting a book by its ID  
- Updating a book  
- Deleting a book  

---

## Testing framework

The tests use **xUnit**, which is a popular and easy-to-use testing framework for .NET projects.

---

## Why test?

Running these tests helps make sure your code is working right and catches mistakes early.

---

