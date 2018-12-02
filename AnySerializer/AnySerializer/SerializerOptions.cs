﻿using System;

namespace AnySerializer
{
    /// <summary>
    /// The serialization options
    /// </summary>
    [Flags]
    public enum SerializerOptions
    {
        /// <summary>
        /// No options specified
        /// </summary>
        None = 0,

        /// <summary>
        /// Specify if you want disable the ignore by attribute feature
        /// </summary>
        DisableIgnoreAttributes = 1,

        /// <summary>
        /// Specify if you want to embed types
        /// </summary>
        EmbedTypes = 2,
    }
}
