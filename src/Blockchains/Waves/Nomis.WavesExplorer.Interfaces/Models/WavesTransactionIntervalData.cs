﻿// ------------------------------------------------------------------------------------------------------
// <copyright file="WavesTransactionIntervalData.cs" company="Nomis">
// Copyright (c) Nomis, 2022. All rights reserved.
// The Application under the MIT license. See LICENSE file in the solution root for full license information.
// </copyright>
// ------------------------------------------------------------------------------------------------------

using System.Numerics;
using System.Text.Json.Serialization;

using Nomis.Blockchain.Abstractions.Models;
using Nomis.WavesExplorer.Interfaces.Extensions;

namespace Nomis.WavesExplorer.Interfaces.Models
{
    /// <inheritdoc cref="ITransactionIntervalData"/>
    public class WavesTransactionIntervalData :
        ITransactionIntervalData
    {
        /// <inheritdoc />
        public DateTime StartDate { get; set; }

        /// <inheritdoc />
        public DateTime EndDate { get; set; }

        /// <inheritdoc />
        [JsonIgnore]
        public BigInteger AmountSum { get; set; }

        /// <inheritdoc cref="ITransactionIntervalData.AmountSum"/>
        public decimal AmountSumValue => AmountSum.ToWaves();

        /// <inheritdoc />
        [JsonIgnore]
        public BigInteger AmountOutSum { get; set; }

        /// <inheritdoc cref="ITransactionIntervalData.AmountOutSum"/>
        public decimal AmountOutSumValue => AmountOutSum.ToWaves();

        /// <inheritdoc />
        [JsonIgnore]
        public BigInteger AmountInSum { get; set; }

        /// <inheritdoc cref="ITransactionIntervalData.AmountInSum"/>
        public decimal AmountInSumValue => AmountInSum.ToWaves();

        /// <inheritdoc />
        public int Count { get; set; }
    }
}