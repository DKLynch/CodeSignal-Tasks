function circleOfNumbers(n, firstNumber)
    nums = {}
    
    for i = 0, n do
        table.insert(nums, i)
    end
    
    if firstNumber < (n/2) then
        return nums[firstNumber + (n/2) + 1]
    else
        return nums[firstNumber - (n/2) + 1]
    end    
end
