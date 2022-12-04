﻿// ------------------------------------------------------------------------------------------------------
// <copyright file="WavesHelpers.cs" company="Nomis">
// Copyright (c) Nomis, 2022. All rights reserved.
// The Application under the MIT license. See LICENSE file in the solution root for full license information.
// </copyright>
// ------------------------------------------------------------------------------------------------------

using System.Numerics;

namespace Nomis.WavesExplorer.Interfaces.Extensions
{
    /// <summary>
    /// Extension methods for Waves.
    /// </summary>
    public static class WavesHelpers
    {
        /// <summary>
        /// Convert Wei value to Waves.
        /// </summary>
        /// <param name="valueInWei">Wei.</param>
        /// <returns>Returns total Waves.</returns>
        public static decimal ToWaves(this in BigInteger valueInWei)
        {
            return (decimal)valueInWei * 0.00_000_001M;
        }

        /// <summary>
        /// Convert Wei value to Waves.
        /// </summary>
        /// <param name="valueInWei">Wei.</param>
        /// <returns>Returns total Waves.</returns>
        public static decimal ToWaves(this decimal valueInWei)
        {
            return new BigInteger(valueInWei).ToWaves();
        }
    }
}