
# Big-O Notation Examples

## Description

This project is a console application that exemplifies various Big-O notations with code examples. It is designed to help developers understand and visualize the time complexity and efficiency of different algorithms.

## Requirements

- Node.js 12 or higher

## Mode of Use

1. Clone the repository:
   ```bash
   git clone https://github.com/ferrerallan/big-o-notation-examples.git
   ```
2. Navigate to the project directory:
   ```bash
   cd big-o-notation-examples
   ```
3. Install the dependencies:
   ```bash
   yarn install
   ```
4. Run the application:
   ```bash
   yarn start
   ```

## Example Usage

Here is a basic example of a Big-O notation implementation in this project:

```typescript
// src/examples/o_n/linearExample.ts

function linearExample(array: number[]) {
  for (let i = 0; i < array.length; i++) {
    console.log(array[i]);
  }
}

// Example usage
const sampleArray = [1, 2, 3, 4, 5];
linearExample(sampleArray);
```

This example demonstrates O(n) complexity, where the execution time increases linearly with the input size.

## License

This project is licensed under the MIT License.
