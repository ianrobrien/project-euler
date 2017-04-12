namespace ProjectEuler

module Library = 

  module Math =

    let Abs x =
      if x < 0 then x * -1
      else x

    let IsEven x =
      x % 2 = 0

    let IsOdd x =
      not (IsEven x)

    let rec Fibonacci n =
      match n with
      | 0 -> n
      | 1 -> n
      | _ -> Fibonacci(n - 2) + Fibonacci(n - 1)

    let rec Factorial n =
      match n with
      | 0 -> 1
      | _ -> n * Factorial(n - 1)

    let rec IsPrime x =
      let root = (int)(sqrt ((float)x))
      let rec isPrimeRec n =
        if n > root then true
        else if ((x % n) = 0) then false
        else isPrimeRec (n + 1)
      isPrimeRec 2

    let IsPalindrome x =
      let rec IsPalindromeRec forwards reverse =
        let digit = forwards % 10
        let reverse = reverse * 10 + digit
        let forwards = forwards / 10
        if forwards > 0 then IsPalindromeRec forwards reverse
        else x = reverse
      IsPalindromeRec x 0