This is a repro of a problem I'm experiencing referencing a PCL from a netstandard library. It's a single-project solution. The project is a netstandard 1.6 library and it is attempting to reference a `portable-net45+win8+wp8+wpa81` PCL.

When building, I get:
```
WhateverMock.cs(6,47,6,66): error CS0012: The type 'Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes'.
```

**UPDATE:** some fine folks on Twitter pointed me in the direction of the [Microsoft.NETCore.Portable.Compatibility](https://www.nuget.org/packages/Microsoft.NETCore.Portable.Compatibility/) NuGet package. It unlocks the scenario in question here, allowing my netstandard project to reference the PCL.