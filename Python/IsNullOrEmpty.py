
def IsNullOrEmpty( input ):
    if input == None:
        return True
    elif len(input) == 0:
        return True
    else:
        return False


print(IsNullOrEmpty(None))
print(IsNullOrEmpty(""))
print(IsNullOrEmpty("hello"))
print(IsNullOrEmpty("null"))