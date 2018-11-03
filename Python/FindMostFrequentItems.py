
# came up with this function without google
def FindMostFrequent( arr ):
    result = list()
    frequency_result = []
    highestCount = 0
    for number in arr:
        numberOfElements = arr.count(number)
        if (number not in frequency_result):
            if (numberOfElements >= highestCount):
                if (numberOfElements > highestCount): 
                    frequency_result = []
                frequency_result.append(number)
                highestCount = numberOfElements

    print(frequency_result)



FindMostFrequent( [1,2,3,4,5,6,7] ) # 1,2,3,4,5,6,7
FindMostFrequent( [1,2,3,4,5,1,6,7] ) # 1
FindMostFrequent( [5,4,3,2,4,5,1,6,1,2,5,4] ) # 5,4