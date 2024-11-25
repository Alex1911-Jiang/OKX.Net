﻿using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OKX.Net.Enums
{
    /// <summary>
    /// Account type
    /// </summary>
    public enum UserAccountType
    {
        /// <summary>
        /// Main account
        /// </summary>
        [Map("0")]
        Main,
        /// <summary>
        /// Standard sub account
        /// </summary>
        [Map("1")]
        StandardSubAccount,
        /// <summary>
        /// Managed trading sub account
        /// </summary>
        [Map("2")]
        ManagedSubAccount,
        /// <summary>
        /// Custody trading sub-account - Copper
        /// </summary>
        [Map("5")]
        CustodySubAccountCopper,
        /// <summary>
        /// Managed trading sub-account - Copper
        /// </summary>
        [Map("9")]
        ManagedSubAccountCopper,
        /// <summary>
        /// Custody trading sub-account - Komainu
        /// </summary>
        [Map("12")]
        CustodySubAccountKomainu
    }
}
