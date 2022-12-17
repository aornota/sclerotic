### <a name="1S_response_to_1C_opening"> 1S response to 1C opening

The {1S} response to a {1C} opening bid shows a three-suited (4441 or 5440) hand with 9+ HCP. This response is forcing to game.

If opener's RHO bids over this reponse, see [coping with interference over game-forcing responses to {1C} opening](#-coping-with-interference-over-game-forcing-responses-to-1c-opening).

Otherwise, opener should bid {1NT} to ask responder to bid their singleton or void at the 2-level. (Note that if opener has a single-suited hand, it is likely that responder's shortness will be in that suit. Nonetheless, even if opener's suit is strong enough to play a contract in that suit opposite a singleton or void, they should still bid {1NT} because in the rare cases where responder's shortness is in another suit, prospects for slam have improved significantly.)

Following responder's shortness-showing bid, opener will make an asking bid:

- Bidding a suit other than responder's short suit at the cheapest level is a [suit-agreement bid](#-suit-agreement-bid) and asks for responder's control count.
- Bidding responder's short suit at the 3-level is also a [suit-agreement bid](#-suit-agreement-bid) - albeit more of an imposition than an agreement, given responder's shortness in the suit - and asks for responder's control count.
  - Note that opener will need a very strong suit to play a contract in that suit opposite a singleton or void. Otherwise, they should prefer an NT contract.
- Bidding {2NT} is an [HCP range ask bid](#-nt-range-ask-bid) and asks for responder's HCP range.

##### Example auction with a suit-agreement bid

The {1C} opener has:

> {| s:AQ74 h:K8532 d:AJ c:KQ --shape --hcp --cc |}

Responder bids {1S} with:

> {| s:KJ98 h:6 d:K543 c:A962 --shape --hcp --cc |}

The auction continues:

- (Opener) {1NT}: asks for shortness
- (Responder) {2H}: heart singleton or void
- (Opener) {2S}: suit-agreement bid (known 8- or 9-card fit)
- (Responder) {3H} (4th step): control count = 4

Opener knows that responder cannot have four Kings, so must either have the other two Aces ({Ah} and {Ac}) - or one of these Aces and the other two Kings ({Ks} and {Kd}). Given that they are known to have a heart singleton or void, they are mostly likely to have specifically {Ac}, {Ks}, and {Kd}.

Barring bad breaks, opener can picture 12 tricks - two top diamonds, three top clubs, four trumps, and three heart ruffs - so places the contract in {6S} (declared by responder).

// TODO-NMB: Run simulation to see how often the contract makes?...

// If opener's LHO has ♠532 ♥QJT7 ♦T8 ♣T875 and opener's RHO has ♠T6 ♥A93 ♦Q9762 ♣J43, can make 6S | 5C | 4H | 5NT (and 4D).

##### Example auction with an HCP range ask bid

The {1C} opener has:

> {| s:K7 h:AKQJ d:7653 c:K86 --shape --hcp --cc |}

Responder bids {1S} with:

> {| s:J983 h:9 d:AKJ8 c:T953 --shape --hcp --cc |}

The auction continues:

- (Opener) {1NT}: asks for shortness
- (Responder) {2H}: heart singleton or void

Although opener knows of an 8- or 9-card fit in diamonds, their awful holding in the suit makes them decide that an NT contract is preferable (especially with a very solid holding responder's short suit), so the auction continues:

- (Opener) {2NT}: HCP range ask
- (Responder) {3C}: 9-10 HCP

Opener places the contract in {3NT} (declared by them).

// TODO-NMB: Run simulation to see how often the contract makes?...

// If opener's LHO has ♠52 ♥T8652 ♦QT92 ♣AJ and opener's RHO has ♠AQT64 ♥743 ♦4 ♣Q742, can make 3NT (and 2C | 3D | 3H [N-only] | 2H [S-only] | 1S [N-only]).

(* TODO-NMB: More examples?...

N -> ♠K8 ♥AJ64 ♦A65 ♣A532 -- 16 HCP | balanced (2=4=3=4) | CC = 7
E -> ♠AQT763 ♥T953 ♦J ♣KT -- 10 HCP | very unbalanced (6=4=1=2) | CC = 3
S -> ♠9 ♥KQ72 ♦KT83 ♣Q876 -- 10 HCP | unbalanced (1=4=4=4) | CC = 2
W -> ♠J542 ♥8 ♦Q9742 ♣J94 --  4 HCP | unbalanced (4=1=5=3) | CC = 0

N -> 1C: 16+; any shape
(E -> ?)
S -> 1S: 9+; three-suited (4441 | 5440) ; GF
...

-> can make 4H (and 3C | 2D | 2NT [N] | 1NT [S]); (E/W can make 3S)

-----

N -> ♠AJ9 ♥KJ83 ♦A32 ♣A54 -- 17 HCP | balanced (3=4=3=3) | CC = 7
E -> ♠76 ♥652 ♦KT74 ♣JT97 --  4 HCP | balanced (2=3=4=4) | CC = 1
S -> ♠K853 ♥AT74 ♦Q ♣KQ83 -- 14 HCP | unbalanced (4=4=1=4) | CC = 4
W -> ♠QT42 ♥Q9 ♦J9865 ♣62 --  5 HCP | semi-balanced (4=2=5=2) | CC = 0

N -> 1C: 16+; any shape
S -> 1S: 9+; three-suited (4441 | 5440) ; GF
...

-> can make 7H | 6C | 6S | 6NT (and 2D)...

-----

N -> ♠K93 ♥Q4 ♦AKJ82 ♣K92 -- 16 HCP | balanced (3=2=5=3) | CC = 5
E -> ♠T7 ♥T653 ♦9653 ♣AJ4 --  5 HCP | balanced (2=4=4=3) | CC = 2
S -> ♠AQJ8 ♥AK97 ♦Q ♣T875 -- 16 HCP | unbalanced (4=4=1=4) | CC = 5
W -> ♠6542 ♥J82 ♦T74 ♣Q63 --  3 HCP | balanced (4=3=3=3) | CC = 0

N -> 1C: 16+; any shape
S -> 1S: 9+; three-suited (4441 | 5440) ; GF
...

-> can make 6D [N] | 6S [N] | 6NT [N] | 5C | 5H [N] (and 5D [S] | 4H [S] | 5S [S] | 5NT [S])...

-----

N -> ♠T9 ♥AK7 ♦AKQ853 ♣JT -- 17 HCP | semi-balanced (2=3=6=2) | CC = 6
E -> ♠652 ♥JT84 ♦9 ♣AK754 --  8 HCP | unbalanced (3=4=1=5) | CC = 3
S -> ♠KQ84 ♥Q965 ♦6 ♣Q982 --  9 HCP | unbalanced (4=4=1=4) | CC = 1
W -> ♠AJ73 ♥32 ♦JT742 ♣63 --  6 HCP | semi-balanced (4=2=5=2) | CC = 2

N -> 1C: 16+; any shape
S -> 1S: 9+; three-suited (4441 | 5440) ; GF
...

-> can make 3NT (and 2C | 2D | 3H | 2S)

-----



N -> 1C: 16+; any shape
S -> 1S: 9+; three-suited (4441 | 5440) ; GF
...

-> can make...

*)
