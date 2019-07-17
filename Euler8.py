f = open('1000digit_number', 'r')
number = f.read()
number = str(number)
number_slice_products = []

for i in range(0, 1007):            #getting all adjacent 13-tuples
    prod = 1
    number_slice = number[i:i+13]
    number_slice = map(int, number_slice)
    if len(number_slice) == 13:
        for j in range(0, 13):
            prod *= number_slice[j]
            number_slice_products.append(prod)

number_slice_products.sort()
print number_slice_products
