# Three Variations on Fizz Buzz

Here we create three solutions to this problem:

> Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.

See [Using Fizzbuzz to Find Developers Who Grok Coding](https://imranontech.com/2007/01/24/using-fizzbuzz-to-find-developers-who-grok-coding/)

Use three project directories:

```zsh
mkdir -p fizzbuzz/fsharp
mkdir -p fizzbuzz/csharp
mkdir -p fizzbuzz/csharp-object-oriented
```

Create three dotnet console apps:

```zsh
dotnet new console -o fizzbuzz/csharp-object-oriented/fb-oo --language "C#"
dotnet new console -o fizzbuzz/csharp/fizzbuzz --language "C#"
dotnet new console -o fizzbuzz/fsharp/fizzbuzz --language "F#"
```

After coding build them with

```zsh
dotnet build fizzbuzz/fsharp/fizzbuzz/fizzbuzz.fsproj
dotnet build fizzbuzz/csharp/fizzbuzz/fizzbuzz.csproj
dotnet build fizzbuzz/csharp-object-oriented/fb-oo/fb-oo.csproj
```

Expect console output from each to be identical.

```zsh
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz
Done
```

I may not have been fair to csharp-object-oriented, but it was many more lines of code than its functional brethren. (I wrote it first and may have been missed insights I put into later projects.)
