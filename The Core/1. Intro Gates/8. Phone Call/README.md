Some phone usage rate may be described as follows:

first minute of a call costs `min1` cents, each minute from the 2nd up to 10th (inclusive) costs `min2_10` cents each minute after 10th costs `min11` cents. You have `s` cents on your account before the call. What is the duration of the longest call (in minutes rounded down to the nearest integer) you can have?

__Example__

For `min1 = 3`, `min2_10 = 1`, `min11 = 2` and `s = 20` the output should be<br>
`phoneCall(min1, min2_10, min11, s) = 14`.

__Input/Output__

+ __[execution time limit] 3 seconds (cs)__

+ __[input] integer n__<br><br>A positive two-digit integer.<br><br>_Guaranteed constraints:_<br>`10 ≤ n ≤ 99`.

+ __[output] integer__<br><br>The sum of the first and second digits of the input number.