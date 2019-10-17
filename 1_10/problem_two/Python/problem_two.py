sum = 0
k = 1
x = 1

while x < 4000000:
	temp = x + k
	k = x
	if(temp%2 == 0):
		sum = sum + temp
	x = temp
print (sum)

