import math

def FindAllFactors( numberToFactor ): 
    ceiling = int(math.ceil(math.sqrt(numberToFactor)))
    result = list()

    for i in range(1, ceiling + 1):
        if (numberToFactor % i == 0):
            if (int(numberToFactor / i) == i):
                result.append(i)
            else:
                result.append(i)
                result.append(int(numberToFactor / i))
    
    print('The NumberToFactor: %s! With sorted result of factors: %s.'%(numberToFactor,sorted(result)))

FindAllFactors(42)
FindAllFactors(60)