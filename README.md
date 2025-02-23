# F# Mutable Variable Swapping Issue

This example demonstrates a common misunderstanding in F# regarding mutable variables and function parameters.  When you pass mutable variables to a function, the function operates on *copies* of those variables, not the originals. Therefore, attempting to swap variables within a function will not change their values in the calling scope.

## Bug

The provided code aims to swap the values of `x` and `y` using a `swap` function. However, the output will show that the values of `x` and `y` remain unchanged outside of the `swap` function.

## Solution

The solution uses tuples to achieve the desired variable swapping effect. Tuples are immutable values which are passed into the function, so the function returns a new tuple containing the swapped values. These values are then assigned back to the original variables.