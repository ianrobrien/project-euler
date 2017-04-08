namespace ProjectEuler.Tests

module Problem_001_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 001`` ()=
    let result = ProjectEuler.Problem_001.Solution
    printfn "%i" result
    Assert.AreEqual(233168,result)
