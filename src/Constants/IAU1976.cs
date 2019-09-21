// <copyright file="IAU1976.cs" company="Neil McNeight">
// Copyright © 2019 Neil McNeight. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Satellite.Constants
{
    /// <summary>
    /// The International Astronomical Union at its XVIth General Assembly in Grenoble in 1976, accepted Resolution No. 1, a whole new consistent set of astronomical constants recommended for reduction of astronomical observations, and for computation of ephemerides.
    /// </summary>
    public struct IAU1976
    {
        /// <summary>
        /// Astronomical unit of time.
        /// </summary>
        public static readonly UnitsNet.Duration D = new UnitsNet.Duration(86400.0, UnitsNet.Units.DurationUnit.Second);

        /// <summary>
        /// Astronomical unit of mass.
        /// </summary>
        public static readonly UnitsNet.Mass S = new UnitsNet.Mass(1.98892E30, UnitsNet.Units.MassUnit.Kilogram);

        /// <summary>
        /// Astronomical unit of length.
        /// </summary>
        public static readonly UnitsNet.Length A = new UnitsNet.Length(149597870700.0, UnitsNet.Units.LengthUnit.Meter);

        /// <summary>
        /// Gaussian gravitational constant.
        /// </summary>
        /// <remarks>
        /// Defining constant.
        /// </remarks>
        public static readonly decimal k = 0.01720209895m;

        /// <summary>
        /// Speed of light.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly UnitsNet.Speed c = new UnitsNet.Speed(299792458.0, UnitsNet.Units.SpeedUnit.MeterPerSecond);

        /// <summary>
        /// Light-time for unit distance (A / c).
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly UnitsNet.Duration t_A = new UnitsNet.Duration(499.004782, UnitsNet.Units.DurationUnit.Second);

        /// <summary>
        /// Equatorial radius for Earth.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly UnitsNet.Length a_e = new UnitsNet.Length(6378140.0, UnitsNet.Units.LengthUnit.Meter);

        /// <summary>
        /// Dynamical form-factor for Earth.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly decimal J_2 = 108263.0E-8m;

        public static UnitsNet.Volume mew = new UnitsNet.Volume(398600.4418, UnitsNet.Units.VolumeUnit.CubicKilometer);
        public static double mu = 398600.4418; // km^3/s^2
        public static double re = 6378.137;    // km
    }
}
