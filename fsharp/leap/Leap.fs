module Leap

let leapYear (year: int): bool = 
    let yearIsEvenlyDivisibleBy(divisor: int) = 
        year % divisor = 0

    yearIsEvenlyDivisibleBy(4) && not ( yearIsEvenlyDivisibleBy(100) && not (yearIsEvenlyDivisibleBy(400)) )

 

