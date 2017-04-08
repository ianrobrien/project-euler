namespace ProjectEuler

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = 42

  module Math =

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