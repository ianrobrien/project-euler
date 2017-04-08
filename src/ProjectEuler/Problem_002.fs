namespace ProjectEuler

module Problem_002 =

    open Library

    // Even Fibonacci numbers
    // Problem 2
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

    // fetch fibs till 4000000
    // filter evens    

    let FibonacciSequence filterPredicate x =
      let rec getMaxFibonacciElement n x =
        if Math.Fibonacci n < x then getMaxFibonacciElement (n + 1) x
        else n
      [0..getMaxFibonacciElement 0 x]
      |>List.map(Math.Fibonacci)
      |>List.filter(filterPredicate)
      |>List.sum
    
    let Solve stopCondition filterPredicate = FibonacciSequence filterPredicate stopCondition
