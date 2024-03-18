open System
open CountingSort
open CountingSortCSharp

let A = [ { Age = 23; Name = "Jhon"; Height = 175 };
          {  Age = 17; Name = "Michael"; Height = 169 };
          {  Age = 17; Name = "Victoria"; Height = 179 };
          {  Age = 17; Name = "James"; Height = 169 }; ]

let B = [   new Book(Pages = 123);
            new Book(Pages = 189); 
            new Book(Pages = 101); 
            new Book(Pages = 130); 
            new Book(Pages = 123);]

let sortCSharp = new Sorting()

[<EntryPoint>]
let main argv =
    sort B (fun x -> x.Pages) 200 |> printf "Классы C# сортировка F#: %A \n \n" // Классы C# сортировка F# программа F#
    printf "Record'ы F# сортировка C#: \n"
    sortCSharp.Sort(A, 200, (fun x -> x.Height)) |> printf "%A " // Record'ы  F# сортировка C# программа F#
    0