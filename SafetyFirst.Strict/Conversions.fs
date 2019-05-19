[<AutoOpen>]
module Conversions

open System

[<CompilerMessage("This is a partial function.  Use a function from the Byte module or Byte.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline byte x = byte x

[<CompilerMessage("This is a partial function.  Use a function from the Int16 module or Int16.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline int16 x = int16 x

[<CompilerMessage("This is a partial function.  Use a function from the Int32 module or Int32.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline int x = int x

[<CompilerMessage("This is a partial function.  Use a function from the Int32 module or Int32.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline int32 x = int32 x

[<CompilerMessage("This is a partial function.  Use a function from the Int64 module or Int64.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline int64 x = int64 x

[<CompilerMessage("This is a partial function.  Use a function from the Float32 module or Single.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline float32 x = float32 x

[<CompilerMessage("This is a partial function.  Use a function from the Float module or Double.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
let inline float x = float x

module Checked = 
  [<CompilerMessage("This is a partial function.  Use a function from the Byte module or Byte.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  let inline byte x = Checked.byte x

  [<CompilerMessage("This is a partial function.  Use a function from the Int16 module or Int16.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  let inline int16 x = Checked.int16 x

  [<CompilerMessage("This is a partial function.  Use a function from the Int32 module or Int32.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  let inline int x = Checked.int x

  [<CompilerMessage("This is a partial function.  Use a function from the Int32 module or Int32.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  let inline int32 x = Checked.int32 x

  [<CompilerMessage("This is a partial function.  Use a function from the Int64 module or Int64.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  let inline int64 x = Checked.int64 x


let inline private byteParse s = Byte.Parse s
type Byte with
  [<CompilerMessage("This is a partial function.  Use Byte.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = byteParse s

let inline private int16Parse s = Int16.Parse s
type Int16 with
  [<CompilerMessage("This is a partial function.  Use Int16.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = int16Parse s

let inline private int32Parse s = Int32.Parse s
type Int32 with
  [<CompilerMessage("This is a partial function.  Use Int32.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = int32Parse s

let inline private int64Parse s = Int64.Parse s
type Int64 with
  [<CompilerMessage("This is a partial function.  Use Int64.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = int64Parse s

let inline private float32Parse s = Single.Parse s
type Single with
  [<CompilerMessage("This is a partial function.  Use Single.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = float32Parse s

let inline private floatParse s = Double.Parse s
type Double with
  [<CompilerMessage("This is a partial function.  Use Double.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = floatParse s

let inline private dateParse s = DateTime.Parse s
type DateTime with
  [<CompilerMessage("This is a partial function.  Use DateTime.TryParse instead.", 12101, IsHidden=true, IsError=false)>]
  static member inline Parse s = dateParse s

