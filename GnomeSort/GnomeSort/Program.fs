open System

type Channel = { CountSubs : int; Name: string }

let randomList = [ { CountSubs = 247; Name = "Россия23" };
          { CountSubs = 263; Name = "Россия1" }; 
          { CountSubs = 150; Name = "Первый"};
          { CountSubs = 500; Name = "Карусель"};
          { CountSubs = 97; Name = "ТНТ"};
          { CountSubs = 485; Name = "ТВ3"}; ]


let swap (arr : _ list) i =
        let swappedElement = arr.Item(i)
        arr |> List.insertAt (i - 1) swappedElement |> List.removeAt (i + 1)


let gnomeSort arr keySelector =
    let rec Sort arr i j =
        match i with
        | length when i = List.length arr -> arr
        | i when (arr.Item(i - 1) |> keySelector) < (arr.Item(i) |> keySelector) ->
            Sort arr j (j + 1)
        | _ ->
            let arr = swap arr i
            let i = i - 1
            match i with
            | 0 -> Sort arr j (j + 1)  
            | _ ->  Sort arr i j
    
    match arr with
    | [] -> arr
    | _ -> Sort arr 1 2


[<EntryPoint>]
let main arg =
    let sortedArr = gnomeSort randomList (fun x -> x.CountSubs)
    printf "%A" sortedArr
    0