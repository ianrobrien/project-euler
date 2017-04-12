namespace ProjectEuler

module Problem_004 =

    open Library

    // Largest palindrome product
    // Problem 4
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.

    let LargestPalindrome x y =
      let rec multiplyDown first second max =
        if (first = 1) then max
        else
          let product = first * second
          let max = 
            if Math.IsPalindrome product && (product > max) then product
            else max
          if second > 1 then
            multiplyDown first (second-1) max
          else
          multiplyDown (first-1) y max
      multiplyDown x y 0

    let Solve x y = LargestPalindrome x y
