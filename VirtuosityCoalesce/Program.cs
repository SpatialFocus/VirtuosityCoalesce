// <copyright file="Program.cs" company="Spatial Focus GmbH">
// Copyright (c) Spatial Focus GmbH. All rights reserved.
// </copyright>

namespace VirtuosityCoalesce
{
	using Castle.DynamicProxy;
	using VirtuosityCoalesce.Assembly;

	internal class Program
	{
		private static void Main(string[] args)
		{
			ProxyGenerator generator = new ProxyGenerator();
			MyClass myClass = generator.CreateClassProxy<MyClass>(new MyClassInteceptor());

			myClass.Method1();
			myClass.Method2();

			myClass?.Method1();
			myClass?.Method2();
		}
	}
}