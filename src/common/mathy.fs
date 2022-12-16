module Aornota.Redneck.Common.Mathy

open System
open System.Security.Cryptography

exception CountForMeanMustNotBeZeroException

type Mean<[<Measure>] 'u> = {
    Total : int<'u>
    Count : uint }
    with
    static member Create(total, count) =
        if count = 0u then raise CountForMeanMustNotBeZeroException
        { Total = total ; Count = count }
    static member FromList(list) = Mean<_>.Create(list |> List.sum, uint list.Length)
    static member Combine(mean1, mean2) = { Total = mean1.Total + mean2.Total ; Count = mean1.Count + mean2.Count }
    static member Update(mean, value) = { Total = mean.Total + value ; Count = mean.Count + 1u }
    member this.Mean : float<'u> = LanguagePrimitives.FloatWithMeasure (float this.Total / float this.Count)

let random () = RandomNumberGenerator.GetInt32(Int32.MaxValue)

let randoms count =
    [
        for _ in 1..count do
            random ()
    ]

let normalizedRandom () = abs (float (randoms 1 |> List.head) / float Int32.MaxValue)

// See Tomas Petricek's answer to https://stackoverflow.com/questions/4495597/combinations-and-permutations-in-f.
let rec combinations acc size list = seq {
    match size, list with
    | n, h :: t ->
        if n > 0 then yield! combinations (h :: acc) (n - 1) t
        if n >= 0 then yield! combinations acc n t
    | 0, [] -> yield acc
    | _, [] -> () }

