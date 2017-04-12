namespace ProjectEuler.Tests

module Problem_007_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 007`` ()=
    let result = ProjectEuler.Problem_007.Solve 10001
    printfn "%i" result
    Assert.AreEqual(104743,result)
