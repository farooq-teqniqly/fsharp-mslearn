open System
let cards = [21; 3; 1; 7; 9; 23]
let cardFace (card: int) : string = 
    let cardNo: int = card % 13

    if cardNo = 1 then "Ace"
    elif cardNo = 11 then "Jack"
    elif cardNo = 12 then "Queen"
    elif cardNo = 0 then "King"
    else string cardNo

let suit (card: int) : string = 
    let suitNo: int = card / 13

    if suitNo = 0 then "Hearts"
    elif suitNo = 1 then "Spades"
    elif suitNo = 2 then "Diamonds"
    else "Clubs"
    
let shuffle list =
    let random = Random()
    list |> List.sortBy(fun _ -> random.Next())
    
let printCard card =  printfn $"%s{cardFace(card)} of %s{suit(card)}"
let printAll list = List.iter(printCard) list
let take (no: int) (list) = List.take no list

[<EntryPoint>]
let main argv =
    cards |> shuffle |> take 3 |> printAll
    0