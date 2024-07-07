Here is a TypeScript solution for the problem:

```typescript
class ArrayRotator {
    constructor(private arr: number[], private k: number) {}

    rotate() {
        let n = this.arr.length;
        this.k %= n;
        this.reverse(0, n - 1);
        this.reverse(0, this.k - 1);
        this.reverse(this.k, n - 1);
        return this.arr;
    }

    private reverse(start: number, end: number) {
        while (start < end) {
            let temp = this.arr[start];
            this.arr[start] = this.arr[end];
            this.arr[end] = temp;
            start++;
            end--;
        }
    }
}

let arr = [1, 2, 3, 4, 5, 6, 7];
let k = 3;
let arrayRotator = new ArrayRotator(arr, k);
console.log(arrayRotator.rotate());
```

This solution uses the reverse method to rotate the array. It first reverses the entire array, then reverses the first k elements, and finally reverses the remaining elements. This results in the array being rotated to the left by k steps.