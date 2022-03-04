﻿using System.Collections.Generic;
using System.CommandLine.Rendering.Views;
using System.Linq;

namespace Affected.Cli.Views
{
    internal class NugetPackagesTable : TableView<PackageChange>
    {
        public NugetPackagesTable(IEnumerable<PackageChange> nugetPackages)
        {
            this.Items = nugetPackages.OrderBy(x => x.Name).ToList();
            this.AddColumn(p => p.Name, "Name");
            this.AddColumn(p => p.OldVersion, "Old Version");
            this.AddColumn(p => p.NewVersion, "New Version");
        }
    }
}