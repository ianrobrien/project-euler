namespace ProjectEuler.Tests

module Problem_004_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 004`` ()=
    let result = ProjectEuler.Problem_003.Solve 600851475143L
    printfn "%i" result
    Assert.AreEqual(6857,result)
