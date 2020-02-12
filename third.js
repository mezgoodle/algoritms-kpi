let swaps = 0
const qsort = (arr) => {
	if (arr.length < 2) {
		return arr;
	} else {
        // Pivot position. Can be set by 3 methods
        const pivotPosition = 0; // First element
        // const pivotPosition = Math.floor(Math.random() * arr.length); // Middle element
        // const pivotPosition = arr.length-1; // Last element
        
		const pivot = arr[pivotPosition];
		// Elements less or equivalent than the pivot
		const less = arr.filter((value, index) => {
			const isPivot = index === pivotPosition;
			return !isPivot && (value <= pivot);
		});
		// Elements less or equivalent than the pivot
        const greater = arr.filter(value => value > pivot);
        
        // Counting swaps
        swaps += less.length + greater.length
        
		return [...qsort(less), pivot, ...qsort(greater)];
	}
};

const arr = [1, 213, 3, 5, 2, 8, 7];
console.log(qsort(arr));
console.log(swaps);
