// <copyright file="MyClass.cs" company="Spatial Focus GmbH">
// Copyright (c) Spatial Focus GmbH. All rights reserved.
// </copyright>

namespace VirtuosityCoalesce.Assembly
{
	using System;

	public class MyClass
	{
		public virtual void Method1()
		{
			Console.WriteLine("Method1: Non virtual call");
		}

		public void Method2()
		{
			Console.WriteLine("Method2: Non virtual call");
		}
	}
}