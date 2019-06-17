`n` children have got `m` pieces of candy. They want to eat as much candy as they can, but each child must eat exactly the same amount of candy as any other child. Determine how many pieces of candy will be eaten by all the children together. Individual pieces of candy cannot be split.

__Example__

For `n = 3` and `m = 10`, the output should be<br>
`candies(n, m) = 9`.<br><br>

Each child will eat `3` pieces. So the answer is `9`.

__Input/Output__

+ __[time limit] 3 seconds (cs)__

+ __[input] integer n__<br><br>The number of children.<br><br>_Guaranteed constraints:_<br>`1 ≤ n ≤ 10`.

+ __[input] integer m__<br><br>The number of pieces of candy.<br><br>_Guaranteed constraints:_<br>`2 ≤ m ≤ 100`.

+ __[output] integer__<br><br>The total number of pieces of candy the children will eat provided they eat as much as they can and all children eat the same amount.