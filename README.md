This is a repro of a problem I'm experiencing referencing a PCL from a netstandard (1.6) library. When attempting to build, I get:
```
WhateverMock.cs(6,47,6,66): error CS0012: The type 'Object' is defined in an assembly that is not referenced. You must add a reference to assembly 'mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e, Retargetable=Yes'.
```