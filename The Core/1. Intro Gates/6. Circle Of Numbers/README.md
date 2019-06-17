Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighbouring numbers is equal (note that 0 and n - 1 are neighbouring, too).

Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber.

__Example__

For `n = 10` and `firstNumber = 2`, the output should be<br>
`circleOfNumbers(n, firstNumber) = 7`.

__Input/Output__

+ __[execution time limit] 3 seconds (cs)__

+ __[input] integer n__<br><br>A positive two-digit integer.<br><br>_Guaranteed constraints:_<br>`10 ≤ n ≤ 99`.

+ __[output] integer__<br><br>The sum of the first and second digits of the input number.