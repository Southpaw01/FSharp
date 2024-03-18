open System

type Fighter = { Name : string; CountFights : int; Age : int }

let A = [
        { Name = "Mike Tyson"; CountFights = 58; Age = 55 };
        { Name = "Saul Alvarez"; CountFights = 61; Age = 31 };
        { Name = "Floyd Mayweather Jr."; CountFights = 50; Age = 45 };
        { Name = "Roy Jones Jr."; CountFights = 75; Age = 53 };
        { Name = "Emmanuel Manny Pacquiao"; CountFights = 72; Age = 43 };
        { Name = "Tyson Fury"; CountFights = 33; Age = 33 };
        { Name = "Vladimir Usik"; CountFights = 19; Age = 35 }; ]

let swap el1 el2 arr =      // Перестановка элементов
    arr |> List.mapi (fun i v ->
        match i with
        | _ when i = el1 -> arr.[el2]
        | _ when i = el2 -> arr.[el1]
        | _ -> v)

let rec stooge property i j (L : _ list) : _ list = // Сортировка
    let compare L =
        match (j - i) with
        | _ when (j - i > 1) ->
            let t = (j - i + 1) / 3
            stooge property i (j - t) L |>
            stooge property (i + t) j |>
            stooge property i (j - t)
        | _ -> L

    match L.Item(j) with
    | _ when ((L.Item(j) |> property) < (L.Item(i) |> property)) ->
        swap i j L |> compare 
    | _ -> compare L

let addOneToValue x = x + 1

[<EntryPoint>]
let main argv =
    A |> stooge (fun x -> x.Name) 0 (A.Length - 1) |> printf "%A"
    0