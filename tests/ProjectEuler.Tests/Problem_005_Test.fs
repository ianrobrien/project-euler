namespace ProjectEuler.Tests

module Problem_005_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 005`` ()=
    let result = ProjectEuler.Problem_005.Solve 1 20
    printfn "%i" result
    Assert.AreEqual(232792560,result)
