// <copyright file="LLA.cs" company="Neil McNeight">
// Copyright © 2019 Neil McNeight. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;

using CoordinateSharp;
using UnitsNet;

namespace Satellite.Coordinates
{
    /// <summary>
    /// LLA - Latitude, Longitude and Altitude coordinates.
    /// </summary>
    public class LLA
    {
        /// <summary>
        /// Name of satellite being tracked.
        /// </summary>
        public string Name;

        /// <summary>
        /// Latitude, longitude, and date of calculation.
        /// </summary>
        public Coordinate Position;

        /// <summary>
        /// Altitude in kilometers.
        /// </summary>
        public Length Altitude;

        public bool DMS;

        /// <summary>
        /// Initializes a new instance of the <see cref="LLA"/> class.
        /// </summary>
        public LLA()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLA"/> class.
        /// 5-parameter constructor (for decimal degrees).
        /// </summary>
        /// <param name="nm"></param>
        /// <param name="la"></param>
        /// <param name="lo"></param>
        /// <param name="al"></param>
        /// <param name="t"></param>
        public LLA(string nm, double la, double lo, Length al, DateTime t)
        {
            this.Name = nm;
            this.Position.Latitude = new CoordinatePart(la, CoordinateType.Lat);
            this.Position.Longitude = new CoordinatePart(lo, CoordinateType.Long);
            this.Altitude = al;
            this.Position.GeoDate = t;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLA"/> class.
        /// </summary>
        /// <param name="nm"></param>
        /// <param name="lad"></param>
        /// <param name="lam"></param>
        /// <param name="las"></param>
        /// <param name="lod"></param>
        /// <param name="lom"></param>
        /// <param name="los"></param>
        /// <param name="al"></param>
        /// <param name="t"></param>
        public LLA(string nm, int lad, int lam, double las, int lod, int lom, double los, Length al, DateTime t)
        {
            this.Name = nm;

            if (lad < 0)
            {
                this.Position.Latitude = new CoordinatePart(Math.Abs(lad), lam, las, CoordinatesPosition.S);
            }
            else
            {
                this.Position.Latitude = new CoordinatePart(lad, lam, las, CoordinatesPosition.N);
            }

            if (lod < 0)
            {
                this.Position.Longitude = new CoordinatePart(Math.Abs(lod), lom, los, CoordinatesPosition.W);
            }
            else
            {
                this.Position.Longitude = new CoordinatePart(lod, lom, los, CoordinatesPosition.E);
            }

            this.Altitude = al;
            this.Position.GeoDate = t;
        }

        public void SwitchOutput()
        {
            this.DMS = !this.DMS;
        }
    }
}
