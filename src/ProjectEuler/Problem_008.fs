namespace ProjectEuler

module Problem_008 =

    open Checked
    open Library

    // Largest palindrome product
    // Problem 4
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.

    let GetBigNumber bigNumberString = bigNumberString|>Seq.map(fun i -> int32(i.ToString()))

    let GetProduct number = number|>Seq.fold(*) 1

    let GetLargestProduct bigNumber places =
      bigNumber
      |>Seq.windowed(places)
      |>Seq.map(GetProduct)
      |>Seq.max
    
    let Solve bigNumberString places = GetLargestProduct (GetBigNumber bigNumberString) places
