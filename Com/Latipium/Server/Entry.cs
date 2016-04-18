// Entry.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using Com.Latipium.Security;

namespace Com.Latipium.Server {
	/// <summary>
	/// The main class for the server.
	/// </summary>
	public static class Entry {
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args) {
			LatipiumSecurity.Initialize("Com.Latipium.Modules.Server", args.Length > 0 ? args[0] : null);
		}
	}
}

