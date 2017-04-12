namespace ProjectEuler

module Problem_006 =

    open Library

    // Largest palindrome product
    // Problem 4
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    let SumOfSquares x y =
      [x..y]
      |>List.sumBy(fun i -> pown i 2)
    let SquareOfSums x y = pown ([x..y]|>List.sum) 2
    let Solve x y = SquareOfSums x y - (SumOfSquares x y)
