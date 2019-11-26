open System

/// Gets the distance to a given destination 
let getDistance (destination) =
    match destination with
    | "Home" -> 25
    | "Office" -> 50
    | "Stadium" -> 25
    | "Gas station" -> 10
    | _ -> failwith "Unknown destination!"


// Couple of quick tests
getDistance("Home") = 25
getDistance("Stadium") = 25

