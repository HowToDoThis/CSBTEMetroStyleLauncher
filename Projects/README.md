[rickyah/ini-parser](#INI-File-Parser) | [dennismagno/metroframework-modern-ui](#MetroFramework)  
# INI File Parser

A .NET, Mono and Unity3d compatible(*) library for reading/writing INI data from IO streams, file streams, and strings written in C#.

Also implements merging operations, both for complete ini files, sections, or even just a subset of the keys contained by the files.


(*) This library is 100% .NET code and does not have any dependencies on Windows API calls in order to be portable.

[![Build Status](https://travis-ci.org/rickyah/ini-parser.png?branch=master)](https://travis-ci.org/rickyah/ini-parser)

## Version 2.0
Since the INI format isn't really a "standard", version 2 introduces a simpler way to customize INI parsing:

 * Pass a configuration object to an `IniParser`, specifying the behaviour of the parser. A default implementation is used if none is provided.
 
 * Derive from `IniDataParser` and override the fine-grained parsing methods.

---
# MetroFramework

MetroFramework - WinForms on steroids.


Brings the new Modern UI alias Metro UI of Windows 8 to .NET Windows Forms applications. 
