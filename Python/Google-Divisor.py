import math

numberToDetermine = int(input())
inputOfDivisors = input()
divisors = list(map(int,inputOfDivisors.split(' ')))

result = list()

for divisor in divisors:
    if numberToDetermine % divisor == 0:
        result.append(divisor)


print(result)