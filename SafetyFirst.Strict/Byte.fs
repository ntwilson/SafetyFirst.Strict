module Byte

/// <summary>
/// Parses the given string as a byte.
/// Throws if the string is not in a recognized format.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Byte.TryParse or the (|Byte|) pattern matcher from FSharpx.Extras instead.", 12101, IsHidden=true, IsError=false)>]
let inline Parse x = System.Byte.Parse x
