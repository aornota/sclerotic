# ![sclerotic](https://raw.githubusercontent.com/aornota/sclerotic/main/src/resources/tpoc-32x32.png) | sclerotic (pre-_α_)

## Table of contents

* [**Introduction**](#-introduction)
* [**Strong (1C) opening bid**](#-strong-1c-opening-bid)
  * [_**Game-forcing responses to 1C opening bid**_](#-game-forcing-responses-to-1c-opening-bid)
    * [1H response to 1C opening](#-1h-response-to-1c-opening)
    * [1S response to 1C opening](#-1s-response-to-1c-opening)
    * [1NT response to 1C opening](#-1nt-response-to-1c-opening)
    * [2C response to 1C opening](#-2c-response-to-1c-opening)
    * [2D response to 1C opening](#-2d-response-to-1c-opening)
    * [2H response to 1C opening](#-2h-response-to-1c-opening)
    * [2S response to 1C opening](#-2s-response-to-1c-opening)
    * [2NT response to 1C opening](#-2nt-response-to-1c-opening)
    * [Subsequent asking bids](#-subsequent-asking-bids)
      * [_Suit-agreement bid_](#-suit-agreement-bid)
      * [_Suit-suggestion bid_](#-suit-suggestion-bid)
      * [_HCP range ask bid_](#-hcp-range-ask-bid)
  * [_**Non-game-forcing responses to 1C opening bid**_](#-non-game-forcing-responses-to-1c-opening-bid)
    * [1D response to 1C opening](#-1d-response-to-1c-opening)
    * [3-level (and higher) responses to 1C opening](#-3-level-and-higher-responses-to-1c-opening)
  * [_**Coping with interfernce after 1C opening bid**_](#-coping-with-interfernce-after-1c-opening-bid)
    * [Coping with interference over 1C opening](#-coping-with-interference-over-1c-opening)
    * [Coping with interference over game-forcing responses to 1C opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening)
    * [Coping with interference over non-game-forcing responses to 1C opening](#-coping-with-interference-over-non-game-forcing-responses-to-1c-opening)
* [**Other constructive opening bids**](#-other-constructive-opening-bids)
  * [_**1D opening bid**_](#-1d-opening-bid)
  * [_**1H opening bid**_](#-1h-opening-bid)
  * [_**1S opening bid**_](#-1s-opening-bid)
  * [_**1NT opening bid**_](#-1nt-opening-bid)
  * [_**2C opening bid**_](#-2c-opening-bid)
  * [_**2D opening bid**_](#-2d-opening-bid)
* [**Pre-emptive opening bids**](#-pre-emptive-opening-bids)
  * [_**2H opening bid**_](#-2h-opening-bid)
  * [_**2S opening bid**_](#-2s-opening-bid)
  * [_**2NT opening bid**_](#-2nt-opening-bid)
  * [_**Other pre-emptive opening bids**_](#-other-pre-emptive-opening-bids)

# <a name="Introduction"> Introduction

Sclerotic is an experimental "strong club" Bridge bidding system.

It has the following notable features:

- All hands with 16+ HCP are opened 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png).
- Balanced (4333, 4432 or 5332) hands with 13-15 HCP are opened 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) - except that if they contain a 5-card major, they are opened 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) or 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png).
- Most unbalanced hands with 11-15 HCP are opened 1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png), 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png), 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) or 2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png). These bids promise 4+ diamonds / 5+ hearts / 5+ spades / 6+ clubs respectively.
- "Problem" unbalanced hands with 11-15 HCP - i.e. those not meeting the minimum suit length restrictions to be opened 1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png), 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png), 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) or 2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) - are opened 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png). The hand shape will be one of 4=4=0=5 / 4=4=1=4 / 4=3=1=5 / 3=4=1=5 / 4=2=2=5 / 2=4=2=5.
- Opening bids higher than 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png) are almost always pre-emptive. (The 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) opening can be semi-constructive, depending on vulnerability.)

Note that HCP ranges are not set in stone, e.g. a balanced hand with a "good 12" HCP could be opened 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) (rather than passed) and a balanced hand with a "bad 16" HCP could also be opened 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) (rather than 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)). Similarly, a very shapely hand with fewer than 16 HCP could be opened 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png). There's no substitute for judgement.

To summarize the 1- and 2-level openings bids:

- [1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#-strong-1c-opening-bid) shows a hand with 16+ HCP. This bid is forcing.
- [1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-1d-opening-bid) shows a hand with 11-15 HCP and 4+ diamonds. This bid is not forcing.
- [1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-1h-opening-bid) shows a hand with 11-15 HCP and 5+ hearts (including 5332 hands with 13-15 HCP). This bid is not forcing.
- [1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-1s-opening-bid) shows a hand with 11-15 HCP and 5+ spades (including 5332 hands with 13-15 HCP). This bid is not forcing.
- [1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-1nt-opening-bid) shows a balanced (4333, 4432 or 5332) hand with 13-15 HCP but without a 5-card major. This bid is not forcing.
- [2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#-2c-opening-bid) shows a hand with 11-15 HCP and 6+ clubs. This bid is not forcing.
- [2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-2d-opening-bid) shows a hand with 11-15 HCP and 4=4=0=5 / 4=4=1=4 / 4=3=1=5 / 3=4=1=5 / 4=2=2=5 / 2=4=2=5 shape. This bid is forcing (with one exception).
- [2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-2h-opening-bid) shows a hand with 6-10 HCP and (usually) 6 hearts. This bid is not forcing.
- [2![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-2s-opening-bid) shows a hand with 6-10 HCP and (usually) 6 spades. This bid is not forcing.
- [2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-2nt-opening-bid) shows a hand with 5+ clubs and 5+ diamonds. The HCP range varies according to vulnerability and seat. This bid is forcing (with one exception).

# <a name="Strong_(1C)_opening_bid"> Strong (1C) opening bid

The 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows any hand with 16+ HCP. Responder should bid as follows if opener's LHO passes:

- With 9+ HCP, make a [game-forcing bid](-game-forcing-responses-to-1c-opening-bid).
- With 0-8 HCP, make a [non-game-forcing bid](-non-game-forcing-responses-to-1c-opening-bid).

If opener's LHO bids, see [coping with interference over 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-1c-opening).

## <a name="Game-forcing_responses_to_1C_opening_bid"> Game-forcing reponses to 1C opening bid

If opener's LHO passes after a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid and responder has 9+ HCP, they should choose one of the following bids - all of which are forcing to game - depending on shape:

- With a balanced (4333, 4432 or 5332) hand, bid [1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-1h-response-to-1c-opening).
- With a three-suited (4441 or 5440) hand, bid [1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-1s-response-to-1c-opening).
- With a single-suiter in clubs (6+ clubs and no other 4+ card suit) - or with a two-suiter (at least 5-4) with longer clubs - bid [1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-1nt-response-to-1c-opening).
- With a single-suiter in diamonds (6+ diamonds and no other 4+ card suit) - or with a two-suiter (at least 5-4) with longer diamonds - bid [2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#-2c-response-to-1c-opening).
- With a single-suiter in hearts (6+ hearts and no other 4+ card suit) - or with a two-suiter (at least 5-4) with longer-or-equal hearts - bid [2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-2d-response-to-1c-opening).
- With a single-suiter in spades (6+ spades and no other 4+ card suit) - or with a spades-and-clubs or spades-and-diamonds two-suiter (at least 5-4) with longer-or-equal spades - bid [2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-2h-response-to-1c-opening).
  - Note that the 2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) response does not include a spades-and-hearts two-suiter. (With longer-or-equal hearts, the response is 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png); with longer spades, the response is 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png).)
- With a two-suiter with equal length in clubs and diamonds, bid [2![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-2s-response-to-1c-opening).
- With a two-suiter in hearts and spades with longer spades, bid [2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-2nt-response-to-1c-opening).

### <a name="1H_response_to_1C_opening"> 1H response to 1C opening

The 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a balanced (4333, 4432 or 5332) hand with 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).




_More coming soon..._

### <a name="1S_response_to_1C_opening"> 1S response to 1C opening

The 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a three-suited (4441 or 5440) hand with 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

Otherwise, opener should bid 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) to ask responder to bid their singleton or void at the 2-level. (Note that if opener has a single-suited hand, it is likely that responder's shortness will be in that suit. Nonetheless, even if opener's suit is strong enough to play a contract in that suit opposite a singleton or void, they should still bid 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) because in the rare cases where responder's shortness is in another suit, prospects for slam have improved significantly.)

Following responder's shortness-showing bid, opener will make an asking bid:

- Bidding a suit other than responder's short suit at the cheapest level is a [suit-agreement bid](#-suit-agreement-bid) and asks for responder's control count.
- Bidding responder's short suit at the 3-level is also a [suit-agreement bid](#-suit-agreement-bid) - albeit more of an imposition than an agreement, given responder's shortness in the suit - and asks for responder's control count.
  - Note that opener will need a very strong suit to play opposite a singleton or void. Otherwise, they should prefer an NT contract.
- Bidding 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) is an [HCP range ask bid](#-nt-range-ask-bid) and asks for responder's HCP range.


### <a name="1NT_response_to_1C_opening"> 1NT response to 1C opening

The 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a single-suiter in clubs (6+ clubs and no other 4+ card suit) - or a two-suiter (at least 5-4) with longer clubs - with 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="2C_response_to_1C_opening"> 2C response to 1C opening

The 2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a single-suiter in diamonds (6+ diamonds and no other 4+ card suit) - or a two-suiter (at least 5-4) with longer diamonds - with 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="2D_response_to_1C_opening"> 2D response to 1C opening

The 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a single-suiter in hearts (6+ hearts and no other 4+ card suit) - or a two-suiter (at least 5-4) with longer-or-equal hearts - with 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="2H_response_to_1C_opening"> 2H response to 1C opening

The 2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a single-suiter in spades (6+ spades and no other 4+ card suit) - or a pades-and-clubs or spades-and-diamonds two-suiter (at least 5-4) with longer-or-equal spades - with 9+ HCP. This response is forcing to game.

Note that the 2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) response does not include a spades-and-hearts two-suiter. (With longer-or-equal hearts, the response is [2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-2d-response-to-1c-opening); with longer spades, the response is [2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-2nt-response-to-1c-opening).)

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="2S_response_to_1C_opening"> 2S response to 1C opening

The 2![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a two-suiter with equal length in clubs and diamonds and 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="2NT_response_to_1C_opening"> 2NT response to 1C opening

The 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a two-suiter in hearts and spades with longer spades and 9+ HCP. This response is forcing to game.

If opener's RHO bids, see [coping with interference over game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="Subsequent_asking_bids"> Subsequent asking bids

After a game-forcing response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid - and assusming that the opponents do not interfere - opener will almost always make an asking bid later in the auction:

- If opener wants to play a suit contact (either in a known fit or with a single-suited hand), they will make a [suit-agreement bid](#-suit-agreement-bid). This asks for responder's control count.
- If opener might want to play a suit contract (depending on responder's support for the suit), they will make a [suit-suggestion bid](#-suit-suggestion-bid). This asks for responder's support for the suit - and, with good support, for responder's control count.
- If opener wants to play an NT contract, they will make an [HCP range ask bid](#-nt-range-ask-bid). This asks for responder's HCP range.

#### <a name="Suit-agreement_bid"> Suit-agreement bid

A suit-agreement bid will usually be made below game. If so, responder should bid according to their control count - where each Ace counts as 2 and each King counts as 1 - as fdllows:

- 1st step: control count = 0 or 1
- 2nd step: control count = 2
- 3rd step: control count = 3
- 4th step: control count = 4
- 5th step: control count = 5
- and so on

Note that if the suit-agreement bid was one level below game and responder has a control count of 6 or more, their bid will be higher than game in the agreed suit. This should not be a problem: slam will often be likely with such a strong hand opposite a strong opener.

If opener next bids the agreed suit at game level or higher, this is to play and responder must pass.


In the rare cases where a suit-agreement bid is made at the game level (i.e. 4![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png), 4![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png), 5![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) or 5![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)), responder should pass with a control count of 3 or less - and otherwise respond as follows:

- 1st step: control count = 4
- 2nd step: control count = 5
- 3rd step: control count = 6
- 4th step: control count = 7
- 5th step: control count = 8
- 6th step: control count = 9 or more

If opener next bids the agreed suit, this is to play and responder must pass.

_More (e.g. opener's other continuations) coming soon..._

#### <a name="Suit-suggestion_bid"> Suit-suggestion bid


A suit-suggestion bid will always be made below game. Responder should bid as follows:

If the suit-suggestion bid was more than one level below game, responder should bid as follows:

- 1st step: 2-card support
- 2nd step: 3-card support without an Ace, King or Queen
- 3rd step: control count = 0 or 1
- 4th step: control count = 2
- 5th step: control count = 3
- and so on

If opener next bids the suggested suit at game level or higher, this is to play and responder must pass.

If the suit-suggestion bid was one level below game, responder should bid as follows:

- 1st step: 2-card support
- 2nd step: 3-card support without an Ace, King or Queen
- 3rd step: control count = 0 or 1
- 4th step: control count = 2
- 5th step: control count = 3 or more

If opener next bids the suggested suit, this is to play and responder must pass.



_More (e.g. opener's other continuations) coming soon..._

#### <a name="HCP_range_ask_bid"> HCP range ask bid


An HCP range ask bid will always made below game (i.e. 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) or 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)). Responder should bid as follows:

- 1st step: 9-10 HCP
- 2nd step: 11-12 HCP
- 3rd step: 13-14 HCP
- 4th step: 15-16 HCP
- 5th step: 17-18 HCP
- and so on

Note that if the HCP range ask bid was 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) and responder has 19+ HCP, their bid will be higher than 3![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png). This should not be a problem: slam will often be likely with such a strong hand opposite a strong opener.

If opener next bids 3![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) or 6![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) (or 7![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)), this is to play and responder must pass.

If opener next bids 4![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) or 5![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png), these are invites to 6![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) and 7![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) respectively. Responder should pass with the lower end of their HCP range and bid the NT slam otherwise.

_More (e.g. opener's other continuations) coming soon..._

## <a name="Non-game-forcing_responses_to_1C_opening_bid"> Non-game-forcing reponses to 1C opening bid

If opener's LHO passes after a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid and responder has 0-8 HCP, they should bid as follows:

- With no 7+ card suit, bid [1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-1d-response-to-1c-opening). This bid forces opener to make at least one more bid if opener's RHO passes.
- With a 7+ card suit, bid [the suit at the 3-level (or higher)](#-other-responses-to-1c-opening). This bid is not forcing.

### <a name="1D_response_to_1C_opening"> 1D response to 1C opening

The 1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png) response to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a hand with 0-8 HCP and no 7+ card suit. This bid forces opener to make at least one more bid if opener's RHO passes.

If opener's RHO bids, see [coping with interference over non-game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-non-game-forcing-responses-to-1c-opening).

_More coming soon..._

### <a name="3-level_(and_higher)_responses_to_1C_opening"> 3-level (and higher) responses to 1C opening

The 3![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png), 3![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png), 3![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png), and 3![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) responses to a 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows a hand with 0-8 HCP and 7+ cards in the suit bid. These bids are not forcing.

If opener's RHO bids, see [coping with interference over non-game-forcing responses to 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening](#-coping-with-interference-over-non-game-forcing-responses-to-1c-opening).


_More (e.g. when to bid higher than the 3-level) coming soon..._

## <a name="Coping_with_interfernce_after_1C_opening_bid"> Coping with interference after 1C opening bid

### <a name="Coping_with_interference_over_1C_opening"> Coping with interference over 1C opening

_Coming soon..._

### <a name="Coping_with_interference_over_game-forcing_responses_to_1C_opening"> Coping with interference over game-forcing responses to 1C opening

_Coming soon..._

### <a name="Coping_with_interference_over_non-game-forcing_responses_to_1C_opening"> Coping with interference over non-game-forcing responses to 1C opening

_Coming soon..._

# <a name="Other_constructive_opening_bids"> Other constructive opening bids

## <a name="1D_opening_bid"> 1D opening bid

_Coming soon..._

## <a name="1H_opening_bid"> 1H opening bid

_Coming soon..._

## <a name="1S_opening_bid"> 1S opening bid

_Coming soon..._

## <a name="1NT_opening_bid"> 1NT opening bid

_Coming soon..._

## <a name="2C_opening_bid"> 2C opening bid

_Coming soon..._

## <a name="2D_opening_bid"> 2D opening bid

_Coming soon..._

# <a name="Pre-emptive_opening_bids"> Pre-emptive opening bids

## <a name="2H_opening_bid"> 2H opening bid

_Coming soon..._

## <a name="2S_opening_bid"> 2S opening bid

_Coming soon..._

## <a name="2NT_opening_bid"> 2NT opening bid

_Coming soon..._

## <a name="Other_pre-emptive_opening_bids"> Other pre-emptive opening bids

_Coming soon..._