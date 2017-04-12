namespace ProjectEuler

module Problem_005 =

    open Library

    // Largest palindrome product
    // Problem 4
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.

    let SmallestMultiple x y =
      let rec smallestMultipleRec n =
        let length = [x..y]|>List.filter(fun i -> n % i = 0)|>List.length
        if length = 20 then n
        else smallestMultipleRec (n + 2)
      smallestMultipleRec 20

    let Solve x y = SmallestMultiple x y
