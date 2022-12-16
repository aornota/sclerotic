# ![sclerotic](https://raw.githubusercontent.com/aornota/sclerotic/main/src/resources/tpoc-32x32.png) | sclerotic (pre-_α_)

## Table of contents

* [**Introduction**](#-introduction)
* [**Strong (1C) opening bid**](#-strong-1c-opening-bid)
  * [_**1D response to 1C opening**_](#-1d-response-to-1c-opening)
  * [_**1H response to 1C opening**_](#-1h-response-to-1c-opening)
  * [_**1S response to 1C opening**_](#-1s-response-to-1c-opening)
  * [_**1NT response to 1C opening**_](#-1nt-response-to-1c-opening)
  * [_**2C response to 1C opening**_](#-2c-response-to-1c-opening)
  * [_**2D response to 1C opening**_](#-2d-response-to-1c-opening)
  * [_**2H response to 1C opening**_](#-2h-response-to-1c-opening)
  * [_**2S response to 1C opening**_](#-2s-response-to-1c-opening)
  * [_**2NT response to 1C opening**_](#-2nt-response-to-1c-opening)
  * [_**Other responses to 1C opening**_](#-other-responses-to-1c-opening)
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
- Balanced (4333, 4432, and 5332) hands with 13-15 HCP are opened 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) - except that if they contain a 5-card major, they are opened 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) or 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png).
- Most unbalanced hands with 11-15 HCP are opened 1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png), 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png), 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) or 2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png). These bids promise 4+ diamonds / 5+ hearts / 5+ spades / 6+ clubs respectively.
- "Problem" unbalanced hands with 11-15 HCP - i.e. those not meeting the minimum suit length restrictions to be opened 1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png), 1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png), 1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png) or 2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) - are opened 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png). The hand shape will be one of 4=4=1=4 / 4=4=0=5 / 4=3=1=5 / 3=4=1=5 / 4=2=2=5 / 2=4=2=5.
- Opening bids higher than 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png) are almost always pre-emptive. (The 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) opening can be semi-constructive, depending on vulnerability.)

Note that HCP ranges are not set in stone, e.g. a balanced hand with a "good 12" HCP could be opened 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) (rather than passed) and a balanced hand with a "bad 16" HCP could also be opened 1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png) (rather than 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)). Similarly, a very shapely hand with fewer than 16 HCP could be opened 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png). There's no substitute for judgement.

To summarize the 1- and 2-level openings bids:

- [1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#-strong-1c-opening-bid) shows a hand with 16+ HCP. This bid is forcing.
- [1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-1d-opening-bid) shows a hand with 11-15 HCP and 4+ diamonds. This bid is not forcing.
- [1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-1h-opening-bid) shows a hand with 11-15 HCP and 5+ hearts (including 5332 hands with 13-15 HCP). This bid is not forcing.
- [1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-1s-opening-bid) shows a hand with 11-15 HCP and 5+ spades (including 5332 hands with 13-15 HCP). This bid is not forcing.
- [1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-1nt-opening-bid) shows a balanced (4333, 4432, and 5332) hand with 13-15 HCP but without a 5-card major. This bid is not forcing.
- [2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#-2c-opening-bid) shows a hand with 11-15 HCP and 6+ clubs. This bid is not forcing.
- [2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-2d-opening-bid) shows a hand with 11-15 HCP and 4=4=1=4 / 4=4=0=5 / 4=3=1=5 / 3=4=1=5 / 4=2=2=5 / 2=4=2=5 shape. This bid is forcing (with one exception).
- [2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-2h-opening-bid) shows a hand with 6-10 HCP and (usually) 6 hearts. This bid is not forcing.
- [2![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-2s-opening-bid) shows a hand with 6-10 HCP and (usually) 6 spades. This bid is not forcing.
- [2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-2nt-opening-bid) shows a hand with 5+ clubs and 5+ diamonds. The HCP range varies according to vulnerability and seat. This bid is forcing (with one exception).

# <a name="Strong_(1C)_opening_bid"> Strong (1C) opening bid

The 1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png) opening bid shows any hand with 16+ HCP. Responder should bid as follows (assuming that RHO has passed):

With 0-8 HCP and no 7+ card suit, bid [1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#1D_response-to-1C-opening-bid). This bid forces opener to make at least one more bid (assuming that LHO passes).

With 0-8 HCP and 7+ card suit, bid [the suit at the 3- or 4-level](#Other-responses-to-1C-opening-bid). This bid is not forcing.

With 9+ HCP, choose one of the following bids - all of which establish a game-force - depending on shape:

- With a balanced (4333, 4432, and 5332) hand, bid [1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-1h-response-to-1c-opening).
- With a three-suited (4441 or 5440) hand, bid [1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-1s-response-to-1c-opening).
- With a single-suiter in clubs (6+ clubs and no other 4+ card suit) - or with a two-suiter (at least 5-4) with longer clubs - bid [1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-1nt-response-to-1c-opening).
- With a single-suiter in diamonds (6+ diamonds and no other 4+ card suit) - or with a two-suiter (at least 5-4) with longer diamonds - bid [2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#-2c-response-to-1c-opening).
- With a single-suiter in hearts (6+ hearts and no other 4+ card suit) - or with a two-suiter (at least 5-4) with longer-or-equal hearts - bid [2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#-2d-response-to-1c-opening).
- With a single-suiter in spades (6+ spades and no other 4+ card suit) - or with a spades-and-clubs or spades-and-diamonds two-suiter (at least 5-4) with longer-or-equal spades - bid [2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#-2h-response-to-1c-opening).
-- Note that the 2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png) response does not include a two-suiter with spades and hearts. (With longer-or-equal hearts, the response is 2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png); with longer spades, the response is 2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png).)
- With a two-suiter with equal length in clubs and diamonds, bid [2![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#-2s-response-to-1c-opening).
- With a two-suiter in hearts and spades with longer spades, bid [2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#-2nt-response-to-1c-opening).

## <a name="1D_response_to_1C_opening"> 1D response to 1C opening

_Coming soon..._

## <a name="1H_response_to_1C_opening"> 1H response to 1C opening

_Coming soon..._

## <a name="1S_response_to_1C_opening"> 1S response to 1C opening

_Coming soon..._

## <a name="1NT_response_to_1C_opening"> 1NT response to 1C opening

_Coming soon..._

## <a name="2C_response_to_1C_opening"> 2C response to 1C opening

_Coming soon..._

## <a name="2D_response_to_1C_opening"> 2D response to 1C opening

_Coming soon..._

## <a name="2H_response_to_1C_opening"> 2H response to 1C opening

_Coming soon..._

## <a name="2S_response_to_1C_opening"> 2S response to 1C opening

_Coming soon..._

## <a name="2NT_response_to_1C_opening"> 2NT response to 1C opening

_Coming soon..._

## <a name="Other_responses_to_1C_opening"> Other responses to 1C opening

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