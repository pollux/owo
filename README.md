# whats-this
> Huohhhh. fuwwy stwing twansfowmew ;3

This is a port of the logic behind @Nepeta's cursed [OWO](https://github.com/Nepeta/OwO) into C#. \
This project has also, in turn, been ported into [JavaScript](https://github.com/zuzak/owo), [Go](https://github.com/mnlwldr/owo), [Raku](https://github.com/kawaii/raku-acme-owo), and [Python](https://github.com/piethrower/OwO).

---

## Installation
Just copy the [source file](OwOify.cs) into your project and import it.

## Usage
```csharp
var owo = new OwOify();

Console.WriteLine(owo.Commence("I have no mouth and I must scream"));
// HIIII! I haz nu mouth and I must scweam XDDD

Console.WriteLine(owo.Translate('I have no mouth and I must scream'))
// I haz nu mouth and I must scweam
```