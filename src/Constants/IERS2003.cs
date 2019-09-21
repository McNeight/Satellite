// <copyright file="IERS2003.cs" company="Neil McNeight">
// Copyright © 2019 Neil McNeight. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Satellite.Constants
{
    /// <summary>
    /// The International Astronomical Union at its XVIth General Assembly in Grenoble in 1976, accepted Resolution No. 1, a whole new consistent set of astronomical constants recommended for reduction of astronomical observations, and for computation of ephemerides.
    /// </summary>
    public struct IERS2003 : System.IEquatable<IERS2003>
    {
        /// <summary>
        /// Speed of light.
        /// </summary>
        /// <remarks>
        /// Defining constant.
        /// </remarks>
        public static readonly UnitsNet.Speed c = new UnitsNet.Speed(299792458.0, UnitsNet.Units.SpeedUnit.MeterPerSecond);

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

        /// <summary>
        /// The equality operator == returns true if its operands are equal, false otherwise.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(IERS2003 left, IERS2003 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// The inequality operator != returns true if its operands are not equal, false otherwise.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(IERS2003 left, IERS2003 right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is IERS2003)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return c.GetHashCode() + t_A.GetHashCode() + A.GetHashCode() + a_e.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns>true.</returns>
        public bool Equals(IERS2003 other) => true;
    }
}
