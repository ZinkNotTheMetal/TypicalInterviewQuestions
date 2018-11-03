# Whiteboard session to find most common element in an array
# BEWARE: This is not the most optimized solution!
def FindMostFrequent( arr ):
    frequency_result = []
    counted_element = []
    highestCount = 0
    for number in arr:
        numberOfElements = arr.count(number)
        if (number not in counted_element):
            if (numberOfElements >= highestCount):
                if (numberOfElements > highestCount): 
                    frequency_result = []
                frequency_result.append(number)
                counted_element.append(number)
                highestCount = numberOfElements

    print(frequency_result)

# Algorithm -
#  Since Python gives us the function .count(element) we can go through each element and get a count and compare that count with the highest
#  If it's tied with the highest then we can add it to the frequency result. If it's a new high we will clear out the frequency result and start over
#  We will also keep track of the numbers in the list that we already went through to help with optimization. Storage is cheaper than calculations 

FindMostFrequent( [1,2,3,4,5,6,7] ) # 1,2,3,4,5,6,7
FindMostFrequent( [1,2,3,4,5,1,6,7] ) # 1
FindMostFrequent( [5,4,3,2,4,5,1,6,1,2,5,4] ) # 5,4