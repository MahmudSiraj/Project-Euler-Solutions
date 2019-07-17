from math import sqrt

def tri_number_generator(n):      # returns nth triangle number
    return int(0.5*n*(n+1))

number_of_divisors = 0      # to initialize the loop
n = 1

while(number_of_divisors < 500):    # stop as soon as numbe rof divisors is over 500
    number_of_divisors = 0          # reset number of divisors for each test triangle number
    tri_number = tri_number_generator(n)
    for i in range(1, int(sqrt(tri_number)//1)+1):
        if tri_number%i == 0:           # if it is a divisor
            if i == sqrt(tri_number):
                number_of_divisors += 1     # sqrt only counts as one divisor
            else:
                number_of_divisors += 2
    n += 1

print "number of divisors of {} is {}".format(tri_number, number_of_divisors)
