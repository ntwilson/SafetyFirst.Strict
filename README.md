## SafetyFirst.Strict

This library is an add-on for [SafetyFirst](https://www.nuget.org/packages/SafetyFirst).  It shadows all partial functions in select modules to make them give compiler warnings.  If you prefer that partial functions be disallowed entirely, you can add the following line to the `<PropertyGroup>` section of your .fsproj file:
```XML
<TreatWarningsAsErrors>true</TreatWarningsAsErrors>
```

These compiler warnings will appear in any project that contains a reference to SafetyFirst.Strict.  The warnings can be bypassed by fully qualifying the method name and thus bypassing the shadowed version, e.g., using `FSharp.Collections.Array.head` instead of `Array.head`.

### Note to library implementers:

This library will introduce warnings for partial functions even if this package is only installed as a transitive dependency, meaning if you write a library using this package, the warnings will be introduced in any project that references your library.  It is recommended that you do not use SafetyFirst.Strict from any public libraries for this reason.
