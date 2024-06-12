# Bootcamp Assignment (Grokking Algorithms)

This is a solution to Exercises in The book Grokking Algorithms, Assigned by the bootcamp

## Exercises

### Chapter 1

- 1.1 Suppose you have a sorted list of 128 names, and you’re searching
  through it using binary search. What’s the maximum number of
  steps it would take?
  solution:
  The maximu steps taken will be **7** steps
  according to this equation
  $$steps = \frac{log_{10} (128)} {log_{10}(2)}$$
  cause the binary search run in logarithmic time

- 1.2 Suppose you double the size of the list. What’s the maximum
  number of steps now?
  solution:
  The maximum steps will be **8** steps
  using the same equation above.
  $$steps = \frac{log_{10} (256)} {log_{10}(2)}$$

- 1.3 You have a name, and you want to ind the person’s phone number
  in the phone book.
  solution:
  The Run time for this can be two things:
  Linera search: $$O(n)$$
  Binary search: $$O(log_{2}(n))$$

- 1.4 You have a phone number, and you want to ind the person’s name
  in the phone book. (Hint: You’ll have to search through the whole
  book!)
  solution:
  since it's linear search, the run time gonna be: $$O(n)$$

- 1.5 You want to read the numbers of every person in the phone book.
  solution:
  Since im reading every input in the book, therfore the run time
  gonna be linear: $$O(n)$$

- 1.6 You want to read the numbers of just the As.
  solution:
  This is still linear run time, because Big-O notaion
  doesn't care about the constants. $$O(n)$$
