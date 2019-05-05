module Int16

/// <summary>
/// Parses the given string as an int.
/// Throws if the string is not in a recognized format.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Int16.TryParse or the (|Int16|) pattern matcher from FSharpx.Extras instead.", 12101, IsHidden=true, IsError=false)>]
let inline Parse x = System.Int16.Parse x
