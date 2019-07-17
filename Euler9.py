from math import sqrt
from math import pow        #power function

def py_triple(a,b):
    c = sqrt(pow(a,2)+pow(b,2))         #pythagoras' theorem
    if c%1 == 0:                        #check c is an integer
        return c
    else:
        return 0

for n in range(1,1000):
    for m in range(1,1000):
        if (py_triple(n, m)) > 0:
            if m+n+py_triple(n,m)==1000:
                print n*m*py_triple(n,m)
            else:
                continue