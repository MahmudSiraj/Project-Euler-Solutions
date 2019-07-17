
def pal_check(a):
    a = str(a)      #convert to sequence
    for n in range(0,len(a)):
        if a[n] == a[len(a)-n-1]:   #check if it is a palindrome digit by digit
            continue
        else:
            return None            #if digits do not match end the function
    return 1

palindromes = []            #empty list of palindromes

for i in range(100,1000,1):
    for j in range(i,1000,1):       #test all products while passing over duplicates
        if pal_check(i*j):
            palindromes.append(i*j)

palindromes.sort()

for p in palindromes:
    print p

