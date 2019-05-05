module Map

/// <summary>
/// Lookup an element in the map, that value if the element is in the domain of the map.
/// Throws if the element is not in the domain of the map.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Map.tryFind or Map.find' instead.", 12101, IsHidden=true, IsError=false)>]
let inline find key map = Map.find key map 

/// <summary>
/// Evaluates the function on each mapping in the collection. Returns the key for the first mapping where the function returns 'true'. 
/// Throws if no such element exists.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Map.tryFindKey instead.", 12101, IsHidden=true, IsError=false)>]
let inline findKey predicate table = Map.findKey predicate table

/// <summary>
/// Searches the map looking for the first element where the given function returns a Some value.
/// Throws if the element is not found.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Map.tryPick or Seq.pick' instead.", 12101, IsHidden=true, IsError=false)>]
let inline pick chooser table = Map.pick chooser table
