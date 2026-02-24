# GeoKinematics
### Mathematical Engineering for High-Performance Geospatial Kinematics

GeoKinematics is a high-precision C# library built on .NET 9.0. It bridges the gap between historical scientific models and modern geodetic calculations to provide a robust engine for distance, velocity, and time calculations.

---

## Overview
The library integrates classical physics with advanced geodesy, utilizing theories from historical scholars such as Al-Biruni, Al-Buzjani, and Ibn Bajja, transforming them into modern computational modules.

---

## Features

### 1. Geodesy Module
The core of the engine responsible for planetary and coordinate-based calculations:
- **Dynamic Earth Radius**: Calculates the Earth's geocentric radius based on latitude instead of using a fixed value.
- **Haversine Formula**: Implementation for calculating the shortest distance between two points on a sphere.
- **Al-Biruni Model**: For calculating the Earth's curvature and horizon distance based on altitude and horizon dip angle.
- **Al-Buzjani Trigonometry**: Advanced spherical trigonometric functions for side and angle calculations.

### 2. Physics and Kinematics Module
A comprehensive suite for real-world motion simulation:
- **Newtonian Laws**: Full implementation of Newton's First, Second, and Third laws of motion for force and equilibrium analysis.
- **Acceleration Engine**: Includes specialized functions for Turbo Acceleration and Emergency Deceleration.
- **Collision Dynamics**: Analytical models for both Elastic and Inelastic collisions.
- **Terminal Velocity**: Determines the maximum constant speed through a fluid.

### 3. Energy and Work
- **Energy Physics**: Calculations for Potential and Kinetic energy.
- **Fuel Consumption**: Estimation of fuel usage based on energy density and joules.
- **Work Done**: Measures energy transfer over specific geodetic distances.

---

## Technical Stack
- **Target Frameworks**: 
  - .NET 6.0, 8.0, 9.0 (High Performance)
  - .NET Standard 2.0 (Maximum Compatibility)
- **Platforms**: Windows, Linux, macOS, Android, iOS (Cross-Platform)
- **Language**: C# 13.0
- **Primary Dependencies**: 
  - `MathNet.Numerics` & `MathNet.Symbolics`
  - `NmeaParser` (GPS Integration)
  - `Microsoft.Maui.Essentials` (Mobile Utilities)
  
## Usage Example

```csharp
using Geodesy.Physics;

double lat1 = 30.0444, lon1 = 31.2357;
double lat2 = 31.2001, lon2 = 29.9187;

double radius = EarthGeocentricRadius.GetRadius(lat1);
double distance = Haversine_Formula.CalculateDistance(lat1, lon1, lat2, lon2, radius);

Console.WriteLine($"Distance: {distance} km");
```#