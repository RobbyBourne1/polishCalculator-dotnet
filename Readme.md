#### Reverse Polish Calculator
For this activity implement a Reverse Polish Notation (RPN) calculator.

See the [Reverse Polish notation wikipedia page](https://en.wikipedia.org/wiki/Reverse_Polish_notation) for a better understanding of RPN.

See the [Example](https://en.wikipedia.org/wiki/Reverse_Polish_notation#Example) to understand the algorithm. Also see [this videp](https://www.youtube.com/watch?v=7ha78yWRDlE) for a good explination of the RPN (warning: the camera work is very wobbly)

#### Getting Started
Fork this repo & clone this repo to get started

```
https://github.com/mdewey/Daily-Project-Reverse-Polish-Calculator
```
#### Assignment
Code the algorithm that is described in the Example of the wiki.

See the starting file for some clues.

#### Hints

- What is "the stack"? The term stack refers to a way of storing/ordering data. You can think of it like a stack of papers/folders. In this assignment you'll only need to interact with the top of the stack: taking items off the top of the stack, doing some calculation, and then putting items back on top of the stack. As you read through the example, you can see that they keep track of what's on the stack. The leftmost number is the "top" of the stack.

- Really read and understand the algorithm before try to write code. Don't be afraid to write it out on paper/whiteboard as a group to wrap your head around it.  

- Test your code with simple tests first (Like `1 2 + ` or `5 3 *`) before trying anything complex (like `3 4 + 5 * 7 - `)

#### Extras
1. Create a another file Bubble. Write the algorithm to bubble sort an array of ints. Test it in the Main class.

2. Create a another file Bubble. Write the algorithm to bubble sort an array of Strings. Test it in the Main class.

Check out this link to get started with the [Bubble Sort] (https://en.wikipedia.org/wiki/Bubble_sort#Step-by-step_example)


#### .NET Extras
1. Refactor to use the IEnumerable `Stack` in place of array

