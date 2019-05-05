module DateTime

/// <summary>
/// Parses the given string as an int.
/// Throws if the string is not in a recognized format.
/// </summary>
[<CompilerMessage("This is a partial function.  Use DateTime.TryParse or the (|DateTime|) pattern matcher from FSharpx.Extras instead.", 12101, IsHidden=true, IsError=false)>]
let inline Parse x = System.DateTime.Parse x
