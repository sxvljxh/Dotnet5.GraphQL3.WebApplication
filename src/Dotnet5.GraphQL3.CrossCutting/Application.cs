﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;

namespace Dotnet5.GraphQL3.CrossCutting
{
    public static class Application
    {
        public static string Prefix { get; } = Assembly.GetEntryAssembly()?.FullName?.Substring(0, 16);

        public static IEnumerable<Assembly> Assemblies { get; } = 
            DependencyContext.Default.RuntimeLibraries
                .Where(library => library.Name.Contains(Prefix))
                .SelectMany(library => library.GetDefaultAssemblyNames(DependencyContext.Default))
                .Select(Assembly.Load);
    }
}