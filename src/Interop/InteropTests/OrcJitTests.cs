// -----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ubiquity.NET.Llvm.Interop;

using static Ubiquity.NET.Llvm.Interop.NativeMethods;

[assembly: CLSCompliant( false )]

#pragma warning disable SA1600
#pragma warning disable CA1801 // externally defined signature

namespace InteropTests
{
    [TestClass]
    public class OrcJitTests
    {
    }
}
