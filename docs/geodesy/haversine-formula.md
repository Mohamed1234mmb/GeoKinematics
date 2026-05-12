### Haversine Formula

Is the calculation of the distance between 2 points on the Earth's surface , given the lines of longitude and latitude


## CalculateDistance

``` csharp
// Here , calculate the distance bewteen two countries based on the assumption that the Earth is a sphere

double Lat1 = 30.0444;
double Lon1 = 31.2357;
double Lat2 = 55.7558;
double Lon2 = 37.6173;

// We assumed that the Earth's radius is (6371 km) based on the assumption that the Earth is a perfect sphere
double EarthRadius = RadiusEarthCenter.AverageRadius();

double distance = HaversineFormula.CalculateDistance(Lat1 , Lon1 , Lat2 , Lon2 , EarthRadiusKM);
Console.WriteLine(distance);
```

>[!TIP]

> 1- if you want to calculate the distance while at a high altitude ex (airplane , mountain , iconic) , you can use the Al-Biruni method for calculating the radius of the Earth

```csharp

double height = 385.8; // height of the iconic tower in Egypt's New Administrative Capital in meters;
double horizonAngle = 0.637; 

double Lat1 = 30.0444; // Cairo
double Lon1 = 31.2357;
double Lat2 = 55.7558; // Moscow
double Lon2 = 37.6173;

// 
double EarthRadius = AlBiruni.CalculateEarthRadius(height, horizonAngle);

double distance = HaversineFormula.CalculateDistance(Lat1 , Lon1 , Lat2 , Lon2 , EarthRadius);
```
> 2- if you wnat to calculate the distance accurltely , you can use the geodesic (Radius Earth Center) calculation

```csharp

// use this when you are traveling or moving between 2 deffrent places. it calculates the average radous of the entire route, to accuate distance caulculations throughout the journey.

// example
double Lat1 = 30.0444; // Cairo
double Lon1 = 31.2357;
double Lat2 = 55.7558; // Moscow
double Lon2 = 37.6173;

// we get the exact average radius bwtween the 2 points
double dynamicRadius = RadiusEarthCenter.BetweenLatitude(Lat1 , Lat2); 

// Use the dynamtic radius insted of a fixed (6371 km) for better accuracy
double distance = HaversineFormula.CalculateDistance(Lat1 , Lon1 , Lat2 , Lon2 , dynamicRadius);
Console.WriteLine(distance);
```

*For more details , see [Haversine Formula](xref:Geodesy.HaversineFormula)**
 