namespace ProjectEuler

module Problem_003 =

    open Library

    // Largest prime factor
    // Problem 3
    // The prime factors of 13195 are 5, 7, 13 and 29.
    // What is the largest prime factor of the number 600851475143 ?

    let LargestPrimeFactor (x : int64) =        
        let root = (int)(sqrt ((float)x))
        [2..root]
        |>List.filter(fun n -> (x % (int64)n = (int64)0) && Math.IsPrime n)
        |>List.max
    
    let Solve x = LargestPrimeFactor x
