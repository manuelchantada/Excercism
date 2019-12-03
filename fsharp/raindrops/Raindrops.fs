module Raindrops

let specialCases = [(3, "Pling"); (5, "Plang"); (7, "Plong")] 


let convert (number: int) =    
    let makeSound (div, sound) =
        if number % div = 0 then sound
        else ""      

    specialCases
        |> List.map makeSound             
        |> String.concat ""
        |> function 
            | "" -> string number
            | x -> x
    
   


