// -----------------------------------------------------------------------
// <copyright file="StringNormalizer.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
using System;

namespace Ubiquity.NET.Llvm.Interop
{
    /// <summary>Used to mark functions that have been stripped and are not supported.</summary>
    public class StrippedFunctionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrippedFunctionException"/> class.
        /// </summary>
        /// <param name="message">message</param>
        public StrippedFunctionException(string message)
            : base( message )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrippedFunctionException"/> class.
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="innerException">innerException</param>
        public StrippedFunctionException(string message, Exception innerException)
            : base( message, innerException )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrippedFunctionException"/> class.
        /// </summary>
        public StrippedFunctionException()
        {
        }
    }
}
