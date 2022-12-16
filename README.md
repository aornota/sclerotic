# ![sclerotic](https://raw.githubusercontent.com/aornota/sclerotic/main/src/resources/tpoc-32x32.png) | sclerotic (pre-_α_)

## Table of contents

* [**Introduction**](#Introduction)

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

- [1![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#1C_opening) shows a hand with 16+ HCP. This bid is forcing.
- [1![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#1D_opening) shows a hand with 11-15 HCP and 4+ diamonds. This bid is not forcing.
- [1![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#1H_opening) shows a hand with 11-15 HCP and 5+ hearts (including 5332 hands with 13-15 HCP). This bid is not forcing.
- [1![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#1S_opening) shows a hand with 11-15 HCP and 5+ spades (including 5332 hands with 13-15 HCP). This bid is not forcing.
- [1![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#1NT_opening) shows a balanced (4333, 4432, and 5332) hand with 13-15 HCP but without a 5-card major. This bid is not forcing.
- [2![C](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/C.png)](#2C_opening) shows a hand with 11-15 HCP and 6+ clubs. This bid is not forcing.
- [2![D](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/D.png)](#2D_opening) shows a hand with 11-15 HCP and 4=4=1=4 / 4=4=0=5 / 4=3=1=5 / 3=4=1=5 / 4=2=2=5 / 2=4=2=5 shape. This bid is forcing (with one exception).
- [2![H](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/H.png)](#2H_opening) shows a hand with 6-10 HCP and (usually) 6 hearts. This bid is not forcing.
- [2![S](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/S.png)](#2S_opening) shows a hand with 6-10 HCP and (usually) 6 spades. This bid is not forcing.
- [2![NT](https://raw.githubusercontent.com/aornota/redneck/main/src/resources/NT.png)](#2NT_opening) shows a hand with 5+ clubs and 5+ diamonds. The HCP range varies according to vulnerability and seat. This bid is forcing (with one exception).
