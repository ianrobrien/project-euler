namespace ProjectEuler.Tests

module LibraryTests =

  open ProjectEuler
  open NUnit.Framework
  
  [<Test>]
  let ``hello returns 42`` () =
    let result = Library.hello 42
    printfn "%i" result
    Assert.AreEqual(42,result)
  
  [<Test>]
  let ``IsEven correct for even value`` ()=
    let result = Library.Math.IsEven 93832
    printfn "%b" result
    Assert.AreEqual(true,result)
  
  [<Test>]
  let ``IsEven correct for odd value`` ()=
    let result = Library.Math.IsEven 93831
    printfn "%b" result
    Assert.AreEqual(false,result)