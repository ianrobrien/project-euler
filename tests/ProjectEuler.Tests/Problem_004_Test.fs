namespace ProjectEuler.Tests

module Problem_004_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 004`` ()=
    let result = ProjectEuler.Problem_004.Solve 999 999
    printfn "%i" result
    Assert.AreEqual(906609,result)
