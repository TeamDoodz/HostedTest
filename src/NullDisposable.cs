﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostedTest;

internal sealed class NullDisposable : IDisposable {
	public static NullDisposable Instance { get; } = new NullDisposable();

	/// <inheritdoc />
	public void Dispose() {
	}
}
