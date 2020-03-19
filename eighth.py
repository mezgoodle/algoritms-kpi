# Algorithm itself
def knapSack(W, wt, val, n): 
	K = [[0 for x in range(W + 1)] for x in range(n + 1)] 

	# Build table K[][] in bottom up manner 
	for i in range(n + 1): 
		for w in range(W + 1): 
			if i == 0 or w == 0: 
				K[i][w] = 0
			elif wt[i-1] <= w: 
				K[i][w] = max(val[i-1] + K[i-1][w-wt[i-1]], K[i-1][w]) 
			else: 
				K[i][w] = K[i-1][w] 

	return K[n][W] 

# Input values of items
val = [60, 100, 120, 230] 
# Input weigth of items
wt = [10, 20, 30, 30]
# Input weight of pack
W = 50
n = len(val)
# Output data
print(knapSack(W, wt, val, n))