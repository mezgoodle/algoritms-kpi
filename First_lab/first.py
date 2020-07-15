# Input array
arr = list(map(int, input().split(', ')))

arr_even = list()
arr_odd = list()

def check_elements(arr):
    for element in arr:
        if element % 2 == 0:
            arr_even.append(element)
        else:
            arr_odd.append(element)

# # Function to do insertion sort 
def insertionSort(arr): 
    for i in range(1, len(arr)): 
        key = arr[i] 
#         Move elements of arr[0..i-1], that are 
#         greater than key, to one position ahead 
#         of their current position 
        j = i-1
        while j >= 0 and key < arr[j] : 
                arr[j + 1] = arr[j] 
                j -= 1
        arr[j+1] = key

# Select elements in two arrays
check_elements(arr)

# Sort itself
insertionSort(arr_even)
insertionSort(arr_odd)

# Reverse array for task
arr_odd.reverse()

#Output data
print(arr_even + arr_odd)