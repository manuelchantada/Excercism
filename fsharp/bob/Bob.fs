module Bob

let response (input: string): string =  
    let (|Question|_|) (s: string) = 
        if s.TrimEnd().EndsWith("?") then Some(Question )
        else None

    let (|Shouting|_|) (s: string) =
        if (s.ToUpper() = s && s.ToLower() <> s ) then Some(Shouting)
        else None
    
    let (|Exclaming|_|) (s: string) =      
        if s.EndsWith("!") then Some(Exclaming) 
        else None

    match input.Trim() with
    | Question & Shouting -> "Calm down, I know what I'm doing!"
    | Question -> "Sure."
    | Shouting -> "Whoa, chill out!"
    | Exclaming -> "Whatever."
    | "" -> "Fine. Be that way!"
    | _ -> "Whatever."
    

