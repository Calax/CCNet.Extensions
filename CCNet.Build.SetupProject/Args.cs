﻿using System;
using CCNet.Build.Common;
using Lean.Configuration;

namespace CCNet.Build.SetupProject
{
	public static class Args
	{
		public static ArgumentProperties Current { get; set; }

		public static ProjectType ProjectType
		{
			get { return Current.Get<ProjectType>("ProjectType"); }
		}

		public static string ProjectName
		{
			get { return Current.Get<string>("ProjectName"); }
		}

		public static string ProjectBranch
		{
			get { return Current.IsEmpty("ProjectBranch") ? null : Current.Get<string>("ProjectBranch"); }
		}

		public static string PackageId
		{
			get { return Current.Get("PackageId", ProjectName); }
		}

		public static string ProjectPath
		{
			get { return Current.Get<string>("ProjectPath"); }
		}

		public static string ReferencesPath
		{
			get { return Current.Get("ReferencesPath", String.Empty); }
		}

		public static string RelatedPath
		{
			get { return Current.Get("RelatedPath", String.Empty); }
		}

		public static string TempPath
		{
			get { return Current.Get<string>("TempPath"); }
		}

		public static string TfsPath
		{
			get { return Current.Get<string>("TfsPath"); }
		}

		public static string CurrentVersion
		{
			get { return Current.Get<string>("CurrentVersion"); }
		}
	}
}
