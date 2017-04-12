namespace ProjectEuler.Tests

module Problem_006_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 006`` ()=
    let result = ProjectEuler.Problem_006.Solve 1 100
    printfn "%i" result
    Assert.AreEqual(25164150,result)
