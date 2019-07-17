LIMIT = 2000000
total = 0

primes = []

def prime_test(a):      #sieve of Erosthenes
    for p in primes:
        if p*p <= a:
            if a%p == 0:
                return None
        else:
            break
    primes.append(a)


for n in range(2,LIMIT):
    prime_test(n)
print sum(primes)

