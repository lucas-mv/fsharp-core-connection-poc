namespace FormulaLibrary


module Squares = 

    let square x = x * x

    let sumOfSquares n = 
       [1..n] |> List.map square |> List.sum

module Pricing = 
    
    let estimate initial modifier = 
        initial * (1.0 + modifier / 100.0)