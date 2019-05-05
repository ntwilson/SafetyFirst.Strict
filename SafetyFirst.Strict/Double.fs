module Double

/// <summary>
/// Parses the given string as a float.
/// Throws if the string is not in a recognized format.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Double.parse or the (|Double|) pattern matcher from FSharpx.Extras instead.", 12101, IsHidden=true, IsError=false)>]
let inline Parse x = System.Double.Parse x
