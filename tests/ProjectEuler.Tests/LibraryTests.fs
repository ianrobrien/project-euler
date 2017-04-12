namespace ProjectEuler.Tests

module LibraryTests =

  open ProjectEuler
  open NUnit.Framework
  
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

  [<Test>]
  let ``IsPrime correct for prime value`` ()=
    let result = Library.Math.IsPrime 7
    printfn "%b" result
    Assert.AreEqual(true,result)

  [<Test>]
  let ``IsPrime correct for non-prime value`` ()=
    let result = Library.Math.IsPrime 93830
    printfn "%b" result
    Assert.AreEqual(false,result)

  [<Test>]
  let ``IsPalindrome correct for palindromes`` ()=
    let result = Library.Math.IsPalindrome 6432346
    printfn "%b" result
    Assert.AreEqual(true,result)

  [<Test>]
  let ``IsPalindrome correct for non-palindromes`` ()=
    let result = Library.Math.IsPalindrome 284543634
    printfn "%b" result
    Assert.AreEqual(false,result)