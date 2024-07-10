# Question: How do you rotate an array to the left by k steps without using extra space? JavaScript Summary

The JavaScript code provided is a solution to the problem of rotating an array to the left by k steps without using extra space. The solution involves two functions: `rotateArray` and `reverseArray`. The `rotateArray` function takes two parameters: the array to be rotated and the number of steps to rotate. It first calculates the modulus of k and the length of the array to handle cases where k is greater than the array length. Then, it calls the `reverseArray` function three times: first to reverse the entire array, second to reverse the first k elements, and third to reverse the remaining elements. The `reverseArray` function is a helper function that takes an array and two indices as parameters and reverses the elements in the array between those indices. The result of these operations is the original array rotated to the left by k steps. The solution is efficient as it does not require additional space and performs the rotation in-place.

---

# TypeScript Differences

The TypeScript version solves the problem in a similar way to the JavaScript version. Both versions use the same logic of reversing the entire array, then reversing the first k elements, and finally reversing the remaining elements. 

However, the TypeScript version is implemented in an object-oriented way using a class, while the JavaScript version uses standalone functions. The TypeScript version also uses access modifiers (private) to restrict access to the `reverse` method and the `arr` and `k` properties, which is a feature not available in JavaScript.

In the TypeScript version, the `arr` and `k` parameters are passed to the `ArrayRotator` constructor and stored as private properties. The `rotate` and `reverse` methods then operate on these properties. This encapsulates the array rotation logic within the `ArrayRotator` class, making the code more modular and easier to manage.

In terms of type safety, the TypeScript version is more robust because it explicitly specifies the types of the `arr` and `k` properties as well as the parameters and return values of the methods. This can help prevent type-related bugs and improve the readability and maintainability of the code. 

In contrast, the JavaScript version does not have any type annotations, so it relies on JavaScript's dynamic typing, which can potentially lead to type-related bugs if the functions are used incorrectly.

---

# C++ Differences

The C++ version of the solution uses the same logic as the JavaScript version. Both versions use a helper function to reverse sections of the array, and both use the same three-step process to rotate the array: reverse the entire array, reverse the first k elements, and then reverse the remaining elements.

The main differences between the two versions are due to the differences between the C++ and JavaScript languages:

1. Array Representation: In JavaScript, arrays are a built-in type and can be manipulated directly. In C++, arrays are not as flexible, so the solution uses a `vector` (a dynamic array) instead.

2. Function Parameters: In JavaScript, arrays are passed by reference to functions, so changes to the array inside the function affect the original array. In C++, vectors are also passed by reference using the `&` operator to achieve the same effect.

3. Output: The JavaScript version returns the rotated array, while the C++ version does not return anything. Instead, it modifies the original vector and then prints the rotated vector in the `main` function.

4. Modulo Operator: Both versions use the modulo operator (`%`) to ensure that k is less than the length of the array. This is done in the same way in both languages.

5. Variable Declaration: In JavaScript, variables can be declared with `let`. In C++, variables are declared with their type (e.g., `int` for integers).

6. Console Output: JavaScript uses `console.log` to print to the console, while C++ uses `cout`.

---
