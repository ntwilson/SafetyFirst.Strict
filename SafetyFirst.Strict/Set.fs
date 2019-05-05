module Set

/// <summary>
/// Returns the highest element in the set according to the ordering being used for the set.
/// Throws if the set is empty.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Seq.max' instead.", 12101, IsHidden=true, IsError=false)>]
let inline maxElement xs = Set.maxElement xs

/// <summary>
/// Returns the lowest element in the set according to the ordering being used for the set.
/// Throws if the set is empty.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Seq.min' instead.", 12101, IsHidden=true, IsError=false)>]
let inline minElement xs = Set.minElement xs 
