// F# code for the types and functions for the Prolog implementation

type Term = Var of string | Const of string | Compound of string * Term list
type Clause = Fact of Term | Rule of Term * Term list
type Goal = Term list
type Query = Goal

let unify (t1: Term) (t2: Term) : (string * Term) list option = failwith "not implemented"
let apply (s: (string * Term) list) (t: Term) : Term = failwith "not implemented"
let solve (c: Clause list) (q: Query) : (string * Term) list list option = failwith "not implemented"
