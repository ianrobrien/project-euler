namespace ProjectEuler

module Problem_007 =

    open Library

    // Largest palindrome product
    // Problem 4
    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    // Find the largest palindrome made from the product of two 3-digit numbers.
    
    let GetPrime x =
      let rec getPrimeRec currentNum n =
        if Math.IsPrime currentNum then
          if x = n then currentNum
          else getPrimeRec (currentNum + 1) (n + 1)
        else
          getPrimeRec (currentNum + 1) n
      getPrimeRec 2 1

    let Solve x = GetPrime x