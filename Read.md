Best case. On Set 1, Bubble Sort and Insertion Sort both only needed 4 comparisons and 0 swaps, while Selection Sort still needed 10 comparisons. 
Explain, in your own words,why Selection Sort can't take a shortcut here the way the other two can, even though the array was already perfectly sorted.
	Selection sort cannot take a shortcut because it must run through each item at every index to find where it belongs

Worst case. On Set 2, Bubble Sort and Insertion Sort both hit exactly 10 comparisons and 10 swaps/moves, the maximum possible for n = 5. Why do you think their numbers end up identical, even though one algorithm swaps neighbors and the other shifts elements? 
(Hint: think about what a single "fix" accomplishes in each one.)
	They have tge same becasue they both compare two elements whereas selection looks at one and compares to the rest

Fewer swaps, same comparisons. On both Set 2 and Set 3, Selection Sort's comparison count matches Bubble Sort and Insertion Sort almost exactly, but its swap count is dramatically lower (2 instead of 10, and 4 instead of 10). 
What is Selection Sort "paying for" instead of extra swaps? Where does its cost actually go?
	It is paying for comparing it to each other element in the array

Total operations as a stand-in for real-world speed. Selection Sort has the lowest total operations count on Set 2 (12, vs. 20 for the other two) and on Set 3 (19, vs. 25 and 23). Does that mean Selection Sort is always the fastest choice in practice? 
Consider: is a "swap" (moving two whole elements) as cheap as a "comparison" (just checking two values)? Would your answer change if you were sorting large records (like whole student transcripts) instead of single integers?
	In practice, no because as the lists get really massive, comparions add up quick as seen with the O(n) of selection

Naming check. Using what you observed above, not just the definitions from Part 1, explain in one sentence each why the swap/move pattern you counted for Bubble Sort and Insertion Sort fits their names, and why Selection Sort's comparison pattern (rather than its swap pattern) is what fits its name.
	Bubble sort is a fitting name because the larger elements float towards the top like a bubble
	Insertion sort is a fitting name because it as it finds the right place for an element, it inserts it there and the rest of the data moves up
	Selection sort is fitting because it selects where elements go and builds the list nearly from scratch

Predict before you run it. Without running the program yet, predict: if you handed your program the array [2, 1, 4, 3, 6, 5] (n = 6, partially out of order in pairs), would you expect Selection Sort's comparison count to be higher, lower, or the same as it was for Set 3? 
Explain your reasoning, then actually run it and check.
	Prediction: The same as selection sort alwats compares each value so if two arrays have the same number of values, comparisons would be the same
	Actual: They were the same
