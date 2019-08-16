module Car

open System

//TODO: Create helper functions to provide the building blocks to implement driveTo.

/// Drives to a given destination given a starting amount of petrol
let driveTo (petrol, destination) = 
    let distance = 
        match destination with
        | "Home" -> 25
        | "Office" -> 50
        | "Stadium" -> 25
        | "Gas station" -> 10
        | _ -> failwith "Unknown destination!"
    if distance > petrol then
        failwith ""

    


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