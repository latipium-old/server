﻿// AssemblyInfo.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("Com.Latipium.Server")]
[assembly: AssemblyDescription("The server for Latipium")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Latipium")]
[assembly: AssemblyProduct("Com.Latipium.Server")]
[assembly: AssemblyCopyright("Zach Deibert")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.0.*")]

[assembly: CLSCompliant(true)]
