namespace starterModuleMvcFsharp.Models 

[<CLIMutable>]
type Home =
    { Message: string
      Name: string }

[<CLIMutable>]
type Settings =
    { Setting1: bool
      Setting2: System.DateTime }

namespace starterModuleMvcFsharp.Services 
    type IMyService =
        abstract member DnnHello: unit -> string
        abstract member DnnHelloPersonalize: string -> string

    type MyService () = 
        interface IMyService with
            member _.DnnHello () = "Hello from F#"
            member _.DnnHelloPersonalize name = "Hello " + name + " from F#"