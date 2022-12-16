module Aornota.Redneck.Domain.Random.Deal

open Aornota.Redneck.Domain.Core
open Aornota.Redneck.Domain.Deal

open System

let private random = Random()

type Deal with
    static member MakeRandom() =
        let vulnerability () = match random.Next(2) with | 0 -> NotVulnerable | _ -> Vulnerable
        let dealer = match random.Next(4) with | 0 -> North | 1 -> East | 2 -> South | _ -> West
        Deal.Make(dealer, vulnerability (), vulnerability ())
