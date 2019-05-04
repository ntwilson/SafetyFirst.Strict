module Map

/// <summary>
/// Lookup an element in the map, that value if the element is in the domain of the map.
/// Throws if the element is not in the domain of the map.
/// </summary>
[<CompilerMessage("This is a partial function.  Use Map.tryFind or Map.find' instead.", 12101, IsHidden=true, IsError=false)>]
let inline find key map = Map.find key map 

// /// <summary>
// /// Lookup an element in the map, returning an Ok value if the element is in the domain of the map
// /// and an Error if not.
// /// </summary>
// let inline findSafe key map = find' key map

// let private duplicates xs = 
//   [ for (x, count) in xs |> Seq.countBy fst do if count > 1 then yield x ]

// /// <summary>
// /// Returns a new map made from the given bindings, provided all keys are unique.
// /// Returns an Error if any duplicate keys were found.
// /// </summary>
// let ofList' xs = 
//   let result = Map.ofList xs
//   if List.length xs <> Map.count result
//   then Error <| duplicateKeysErr (duplicates xs) 
//   else Ok result

// /// <summary>
// /// Returns a new map made from the given bindings, provided all keys are unique.
// /// Returns an Error if any duplicate keys were found.
// /// </summary>
// let inline ofListSafe xs = ofList' xs 

// /// <summary>
// /// Returns a new map made from the given bindings, provided all keys are unique.
// /// Returns an Error if any duplicate keys were found.
// /// </summary>
// let ofArray' xs =
//   let result = Map.ofArray xs
//   if Array.length xs <> Map.count result
//   then Error <| duplicateKeysErr (duplicates xs)
//   else Ok result

// /// <summary>
// /// Returns a new map made from the given bindings, provided all keys are unique.
// /// Returns an Error if any duplicate keys were found.
// /// </summary>
// let inline ofArraySafe xs = ofArray' xs

// /// <summary>
// /// Returns a new map made from the given bindings, provided all keys are unique.
// /// Returns an Error if any duplicate keys were found.
// /// </summary>
// let inline ofSeq' xs = ofArray' (Seq.toArray xs)

// /// <summary>
// /// Returns a new map made from the given bindings, provided all keys are unique.
// /// Returns an Error if any duplicate keys were found.
// /// </summary>
// let inline ofSeqSafe xs = ofSeq' xs
