module CountingSort

open CountingSortCSharp

type Person = { Age : int; Name: string; Height : int; }

let A = [ { Age = 23; Name = "Sam"; Height = 175 };
          { Age = 17; Name = "Jack"; Height = 183 }; 
          { Age = 17; Name = "Dustin"; Height = 170 };
          { Age = 45; Name = "Alex"; Height = 160 }; ]


let rec addElement  zn (k : int) A = // Добавление по индексу рекорда в подсписок вспомогательного списка списков
    let updated = zn :: List.item(k) A
    List.take(k) A @ updated :: List.skip(k + 1) A

let rec initializeC k C = // Инициализация вспомогательного списка списков
    match k with
    | 0 -> C
    | _ -> 
        let C = [] :: C
        initializeC (k - 1) C
        
let rec fillC keySelector M C = // Заполнение вспомогательного списка списков
    match M with
    | [] -> C
    | head :: tail ->
        let pos = head |> keySelector // Определение индекса нужного подсписка
        fillC keySelector tail (C |> addElement head pos)


let rec createSortedList (M : _ list) C = // Формирование отсортированного списка
    match C with
    | [] -> M
    | head :: tail ->
        createSortedList (M @ head) tail


let rec sort A keySelector k =
    initializeC k [] |> fillC keySelector A |> createSortedList []

    
let rec sortPeopleByHeight A k =
    sort A (fun x -> x.Height) k

let rec sortBooksByPages A k =
    sort (A |> Seq.toList) (fun (x : Book) -> x.Pages) k