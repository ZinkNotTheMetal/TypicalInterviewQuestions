import math

# This function will find the area of a triangle if possible by passing an array
# [3,4,5] = 6
# [9,12,15] = 54
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

# Tests
FindAreaWithThreePoints( [3,4,5] )
# The ones below are commented out due to them raising exceptions
# To test, remove the comment and run the python file
#FindAreaWithThreePoints( [3,-4,5] ) # Will raise an exception due to negative side
#FindAreaWithThreePoints( [4,5,2,1] ) # Will raise an exception due to more than three points
#FindAreaWithThreePoints( [302, 3, 1] ) #Will raise an exception due to not being a valid triangle