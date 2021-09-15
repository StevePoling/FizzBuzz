dotnet build fsharp/fizzbuzz/fizzbuzz.fsproj
dotnet build csharp/fizzbuzz/fizzbuzz.csproj
dotnet build csharp-object-oriented/fb-oo/fb-oo.csproj

dotnet run --path=csharp-object-oriented/fb-oo --project=csharp-object-oriented/fb-oo/fb-oo.csproj >test0
dotnet run --path=csharp/fizzbuzz --project=csharp/fizzbuzz/fizzbuzz.csproj >test1
dotnet run --path=fsharp/fizzbuzz --project=fsharp/fizzbuzz/fizzbuzz.fsproj >test2

diff test0 test1
c1=$?
diff test1 test2
c2=$?
if [ $c1 -eq 0 -a $c2 -eq 0 ]
then
   echo "Success"
fi
