let double (a: int) : int = a * 2
let half (a: int) : int = a / 2

let sumThenHalf = double >> half

printfn "%d" (sumThenHalf 2)


let list = [7; 11; 3]
let sort (list: int list) = List.sort list
let print (list: int list) = List.iter(fun x -> printfn "%i" x) list

list |> sort |> print