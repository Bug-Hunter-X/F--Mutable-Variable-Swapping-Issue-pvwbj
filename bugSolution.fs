let x = 10
let y = 20
let z = 30

let swap (x, y) = (y, x)

let (x, y) = swap (x, y)
printf "%d %d %d" x y z