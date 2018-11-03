import math

def FindAreaWithThreePoints ( possibleTriangle ):
    if (len(possibleTriangle) > 3):
        raise Exception('InvalidTriangleException')
    for side in possibleTriangle:
        if (side < 0):
            raise Exception('InvalidTriangleException')
    # a^2 + b^2 = c^2
    if ((possibleTriangle[0]*possibleTriangle[0]) + (possibleTriangle[1]*possibleTriangle[1]) != (possibleTriangle[2]*possibleTriangle[2])):
        raise Exception('InvalidTriangleException')
    
    perimeter = (possibleTriangle[0] + possibleTriangle[1] + possibleTriangle[2]) / 2
    area = math.sqrt(perimeter*(perimeter-possibleTriangle[0]) * (perimeter-possibleTriangle[1]) * (perimeter-possibleTriangle[2]) )
    print(area)

FindAreaWithThreePoints( [3,4,5] )
#FindAreaWithThreePoints( [3,-4,5] )
#FindAreaWithThreePoints( [4,5,2,1] )
#FindAreaWithThreePoints( [302, 3, 1] )