namespace ProjectEuler.Tests

module Problem_002_Test =

  open ProjectEuler
  open Library
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 002`` ()=
    let result = ProjectEuler.Problem_002.Solve 4000000 Math.IsEven
    printfn "%i" result
    Assert.AreEqual(4613732,result)
