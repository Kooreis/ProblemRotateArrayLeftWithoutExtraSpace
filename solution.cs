Here is a JavaScript solution for the problem:

```javascript
function rotateArray(arr, k) {
    k = k % arr.length;
    reverseArray(arr, 0, arr.length - 1);
    reverseArray(arr, 0, k - 1);
    reverseArray(arr, k, arr.length - 1);
    return arr;
}

function reverseArray(arr, start, end) {
    while (start < end) {
        let temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
}

console.log(rotateArray([1, 2, 3, 4, 5, 6, 7], 3));
```

This console application rotates an array to the left by k steps without using extra space. It uses a helper function `reverseArray` to reverse the elements in the array. The `rotateArray` function first reverses the entire array, then reverses the first k elements, and finally reverses the remaining elements. The result is the original array rotated to the left by k steps.