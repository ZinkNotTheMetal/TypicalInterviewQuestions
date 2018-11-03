import math

# While I was at a conference for google, they had us come up with a couple of fun games to play,
#  one of these included a word game with different divisors (or factors) attached to a letter and really big numbers that would make up a word
#  I needed a quick way to input the number and the list of 'letters' or factors
numberToDetermine = int(input())
inputOfDivisors = input()
divisors = list(map(int,inputOfDivisors.split(' ')))

result = list()

for divisor in divisors:
    if numberToDetermine % divisor == 0:
        result.append(divisor)


print(result)