function rotateArray(arr, k) {
    k = k % arr.length;
    reverseArray(arr, 0, arr.length - 1);
    reverseArray(arr, 0, k - 1);
    return arr;
}