module Raindrops



let convert (number: int): string =    
    let makeSound(div, sound) =
        match number with
        | i when i % div = 0 ->  sound
        | _ -> ""

    let msg = [(3, "Pling"); (5, "Plang"); (7, "Plong")] 
            |> List.map makeSound 
            |> List.fold(+) "" 

    match msg with
    | "" -> string number
    | _ -> msg
   


