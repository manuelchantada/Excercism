module Bob

let response (input: string): string =  
    let isQuestion (s: string) = 
        s.TrimEnd().EndsWith("?")

    let isShouting (s: string) =
        s.ToUpper() = s && s.ToLower() <> s
    
    let isExclaming (s: string) =      
        s.EndsWith("!")

    let isSilence (s: string) =
        s.Trim() = ""

    match input with
    |_ when isQuestion(input) & isShouting(input) -> "Calm down, I know what I'm doing!"
    |_ when isQuestion(input) -> "Sure."
    |_ when isShouting(input) -> "Whoa, chill out!"
    |_ when isExclaming(input) -> "Whatever."
    |_ when isSilence(input) -> "Fine. Be that way!"
    |_ -> "Whatever."
    

