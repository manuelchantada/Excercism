open System
open Car

let getDestination() =
    Console.Write("Enter destination: ")
    Console.ReadLine()

let mutable petrol = 100

[<EntryPoint>]
let main argv =
    while true do
        try
            let destination = getDestination()
            printfn "Trying to drive to %s" destination
            petrol <- driveTo(petrol, destination)
            printfn "Made it to %s! You have %d petrol left" destination petrol
        with ex -> printfn "ERROR: %s" ex.Message
    0


//1 Your car starts with 100 units of petrol.
//2 The user can drive to one of four destinations. Each destination will consume a
//different amount of petrol:
//a Home—25 units
//b Office—50 units
//c Stadium—25 units
//d Gas station—10 units
//5 If the user tries to drive anywhere else, the system will reject the request.
//6 If the user tries to drive somewhere and doesn’t have enough petrol, the system
//will reject the request.
//7 When the user travels to the gas station, the amount of petrol in the car should
//increase by 50 units.