namespace ProjectEuler.Tests

module Problem_003_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 003`` ()=
    let result = ProjectEuler.Problem_003.Solve 13195
    printfn "%i" result
    Assert.AreEqual(29,result)
