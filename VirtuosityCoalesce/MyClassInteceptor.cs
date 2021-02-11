// <copyright file="MyClassInteceptor.cs" company="Spatial Focus GmbH">
// Copyright (c) Spatial Focus GmbH. All rights reserved.
// </copyright>

namespace VirtuosityCoalesce
{
	using System;
	using Castle.DynamicProxy;

	public class MyClassInteceptor : IInterceptor
	{
		public void Intercept(IInvocation invocation)
		{
			Console.WriteLine($"{invocation.Method.Name}: Virtual call");
		}
	}
}