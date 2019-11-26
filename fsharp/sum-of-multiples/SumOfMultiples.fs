module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 

    
    let multiplesOf (mult: int): int =      
        seq {1..upperBound-1} 
        |> Seq.filter (fun x -> x % mult = 0) 
        |> Seq.sum 

    let sumMultiples(number: int) :int =
        multiplesOf number
    
    let validNumbers = numbers |> List.filter (fun x -> not (x=0) )
    let listOfSums = validNumbers |> List.map multiplesOf    
    let result = listOfSums |> List.sum
    result
