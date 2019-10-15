sum = 0
for x in range(1000):
	if (x/3).is_integer() or (x/5).is_integer():
		sum+=x
print (sum)