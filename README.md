This is a repro of a problem I'm experiencing referencing a PCL from a netstandard library. It's a single-project solution. The project is a netstandard 1.6 library and it is attempting to reference a `portable-net45+win8+wp8+wpa81` PCL.

When building, I get:
```
WhateverMock.cs(6,47,6,66): error CS0012: The type 'Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes'.
```

My VS version info is:
```
Microsoft Visual Studio Enterprise 2017 
Version 15.1 (26403.7) Release
VisualStudio.15.Release/15.1.0+26403.7
Microsoft .NET Framework
Version 4.7.02046

Installed Version: Enterprise

Visual Basic 2017   00369-60000-00001-AA208
Microsoft Visual Basic 2017

Visual C# 2017   00369-60000-00001-AA208
Microsoft Visual C# 2017

Visual C++ 2017   00369-60000-00001-AA208
Microsoft Visual C++ 2017

Visual F# 4.1   00369-60000-00001-AA208
Microsoft Visual F# 4.1

Add New File   3.5
The fastest and easiest way to add new files to any project - including files that start with a dot

ASP.NET and Web Tools 2017   15.0.30320.0
ASP.NET and Web Tools 2017

ASP.NET Web Frameworks and Tools 2017   5.2.50303.0
For additional information, visit https://www.asp.net/

Azure App Service Tools v3.0.0   15.0.30209.0
Azure App Service Tools v3.0.0

Common Azure Tools   1.9
Provides common services for use by Azure Mobile Services and Microsoft Azure Tools.

File Icons   2.7
Adds icons for files that are not recognized by Solution Explorer

HideMenu   1.0
Hides the Visual Studio main menu, similar to Windows Explorer and Internet Explorer

ILSpy.AddIn   1.0
Integration of the ILSpy Decompiler into Visual Studio.

JavaScript Language Service   2.0
JavaScript Language Service

JavaScript Project System   2.0
JavaScript Project System

JavaScript UWP Project System   2.0
JavaScript UWP Project System

KofePackagePackage Extension   1.0
KofePackagePackage Visual Studio Extension Detailed Info

Merq   1.1.17-rc (cba4571)
Command Bus, Event Stream and Async Manager for Visual Studio extensions.

Microsoft MI-Based Debugger   1.0
Provides support for connecting Visual Studio to MI compatible debuggers

Microsoft Visual Studio VC Package   1.0
Microsoft Visual Studio VC Package

Mono Debugging for Visual Studio   Mono.Debugging.VisualStudio
Support for debugging Mono processes with Visual Studio.

NCrunch   
Continuous Testing Tool for .NET
Copyright © 2010-2016 Remco Software Ltd

NuGet Package Manager   4.1.0
NuGet Package Manager in Visual Studio. For more information about NuGet, visit http://docs.nuget.org/.

OpenOnGitHub   1.3
Visual Studio Extension for opening files on GitHub.com

Snippet Designer   1.6.5
Snippet Designer is a Visual Studio plug in which allows you to create and search for snippets inside the IDE

SQL Server Data Tools   15.1.61702.140
Microsoft SQL Server Data Tools

Trailing Whitespace Visualizer   2.5.83
Keeps your code files clean by making it easier than ever to identify and remove any trailing whitespace

TypeScript   2.1.5.0
TypeScript tools for Visual Studio

Visual Studio Tools for Universal Windows Apps   15.0.26403.07
The Visual Studio Tools for Universal Windows apps allow you to build a single universal app experience that can reach every device running Windows 10: phone, tablet, PC, and more. It includes the Microsoft Windows 10 Software Development Kit.

VSColorOutput   2.5
Color output for build and debug windows - http://mike-ward.net/vscoloroutput

Xamarin   4.4.0.34 (3f99c5a)
Visual Studio extension to enable development for Xamarin.iOS and Xamarin.Android.

Xamarin.Android SDK   7.2.0.7 (b16fb82)
Xamarin.Android Reference Assemblies and MSBuild support.

Xamarin.iOS and Xamarin.Mac SDK   10.8.0.174 (7656cc6)
Xamarin.iOS and Xamarin.Mac Reference Assemblies and MSBuild support.
```