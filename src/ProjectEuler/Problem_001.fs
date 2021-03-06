namespace ProjectEuler

module Problem_001 =

    // Multiples of 3 and 5
    // Problem 1
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.    
    let Multiples x y n =
        [0..n-1]
        |>List.filter(fun n -> ((n % x) = 0 || (n % y) = 0))
        |>List.sum

    let Solution = Multiples 3 5 1000