namespace ProjectEuler.Tests

module Problem_003_Test =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``Solve Problem 003`` ()=
    let result = ProjectEuler.Problem_003.Solve 600851475143L
    printfn "%i" result
    Assert.AreEqual(6857,result)
