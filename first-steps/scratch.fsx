open System

let drawCard (tuple: int list * int list) =
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    
    printfn "%i" firstCard
    
    let hand = draw |> List.append [firstCard]
    
    (deck.Tail, hand)

let cards = [0..5]
let hand = []


let d, h = (cards, hand) |> drawCard |> drawCard |> drawCard

printfn $"Deck: %A{d} Hand: %A{h}"

List.iter(fun i -> printfn $"%i{i}") cards

let cards = [0..5]
let evens = List.filter(fun i -> i % 2 = 0) cards

let found = List.tryFind(fun i -> i = 2) evens

printfn $"%A{evens}"

open System
let cards = [0..10]
let random = Random()
List.sortBy(fun _ -> random.Next()) cards |> List.sortDescending |> List.iter(fun i -> printfn $"%i{i}")

printfn $"%A{cards}"

type Person = {FirstName: string; LastName: string}
let people: Person list = [
    {FirstName = "Albert"; LastName = "Einstein"}
    {FirstName = "Marie"; LastName = "Curie"}
]


type Weather = {City: string; Temp: int}

let weatherReport: Weather list = [
    {City = "Seattle"; Temp = 43}
    {City = "Portland"; Temp = 47}
    {City = "Miami"; Temp = 75}
    {City = "Honolulu"; Temp = 80}
]

let sum = List.sumBy(fun (w: Weather) -> w.Temp) weatherReport
let avg = List.averageBy(fun (w: Weather) -> double w.Temp) weatherReport

List.sortByDescending(fun (w: Weather) -> w.Temp) weatherReport
    |> List.iter(fun (w: Weather) -> printfn $"City: %s{w.City} Temp: %i{w.Temp}")
let nobelPrizeWinners = List.map(fun p -> p.FirstName + " " + p.LastName) people
printfn $"%A{nobelPrizeWinners}"

type MagicCreature = {Name: string; Level: int; Attack: int;}
let creatures = [
    {Name = "Dragon"; Level = 2; Attack = 20;}
    {Name = "Orc"; Level = 1; Attack = 5;}
    {Name = "Demon"; Level = 2; Attack = 10;}
]

let creatureComparer (c1: MagicCreature) (c2: MagicCreature) =
    if c1.Level < c2.Level then -1
    else if c1.Level > c2.Level then 1
    else if c1.Attack < c2.Attack then -1
    else if c1.Attack > c2.Attack then 1
    else 0

let sorted = List.sortWith creatureComparer creatures

let l1 = [0..100]
let sum = List.sum l1