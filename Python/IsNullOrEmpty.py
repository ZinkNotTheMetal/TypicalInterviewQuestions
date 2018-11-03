# Quick function to give us the ability to check IsNoneOrEmpty on a variable in Python
def IsNoneOrEmpty( input ):
    if input == None:
        return True
    elif len(input) == 0:
        return True
    else:
        return False


print(IsNoneOrEmpty(None))
print(IsNoneOrEmpty(""))
print(IsNoneOrEmpty("hello"))
print(IsNoneOrEmpty("null"))