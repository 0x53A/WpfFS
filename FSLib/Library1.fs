namespace FSLib

[<CLIMutableAttribute>]
type MyRecord = { Name: string }

[<CLIMutableAttribute>]
type MyRecord2 = { A : MyRecord ; B : int }

