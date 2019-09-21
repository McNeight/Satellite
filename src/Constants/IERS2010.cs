// <copyright file="IERS2010.cs" company="Neil McNeight">
// Copyright © 2019 Neil McNeight. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Satellite.Constants
{
    /// <summary>
    /// The International Astronomical Union at its XVIth General Assembly in Grenoble in 1976, accepted Resolution No. 1, a whole new consistent set of astronomical constants recommended for reduction of astronomical observations, and for computation of ephemerides.
    /// </summary>
    public struct IERS2010
    {
        /// <summary>
        /// Speed of light.
        /// </summary>
        /// <remarks>
        /// Natural defining constant.
        /// </remarks>
        public static readonly UnitsNet.Speed c = new UnitsNet.Speed(299792458.0, UnitsNet.Units.SpeedUnit.MeterPerSecond);

        /// <summary>
        /// Gaussian gravitational constant.
        /// </summary>
        /// <remarks>
        /// Auxiliary defining constant.
        /// </remarks>
        public static readonly decimal k = 0.01720209895m;

        /// <summary>
        /// Astronomical unit in seconds.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly UnitsNet.Duration t_A = new UnitsNet.Duration(499.0047838061, UnitsNet.Units.DurationUnit.Second);

        /// <summary>
        /// Astronomical unit in meters.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly UnitsNet.Length A = new UnitsNet.Length(149597870691.0, UnitsNet.Units.LengthUnit.Meter);

        /// <summary>
        /// Equatorial radius of the Earth.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly UnitsNet.Length a_e = new UnitsNet.Length(6378136.6, UnitsNet.Units.LengthUnit.Meter);

        /// <summary>
        /// Dynamical form-factor.
        /// </summary>
        /// <remarks>
        /// Primary constant.
        /// </remarks>
        public static readonly decimal J_2 = 1.0826359E-3m;
    }
}
