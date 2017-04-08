namespace ProjectEuler

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
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