create database swe_assign2;

USE swe_assign2;

create table users(
	username varchar(45) NOT NULL,
    password varchar(90),
    name varchar(45),
    email varchar(45),
    array_progress int(10) zerofill,
    stack_progress int(10) zerofill,
    queue_progress int(10) zerofill,
    linkedlist_progress int(10) zerofill,
    linearsearch_progress int(10) zerofill,
	binarysearch_progress int(10) zerofill,
    bubblesort_progress int(10) zerofill,
	insertionsort_progress int(10) zerofill,
    mergesort_progress int(10) zerofill,
    accuracy int(10) zerofill,
    PRIMARY KEY(username)
);


CREATE TABLE swe_assign2.array (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is an array?', 'A single variable', 'A collection of variables of different types', 'A collection of variables of the same type', 'A reserved memory location', 'C');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In most programming languages, arrays start indexing from:', '0', '1', '-1', '10', 'A');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is an advantage of using arrays?', 'Dynamic size', 'Random access to elements', 'Inefficient memory usage', 'Slow traversal of elements', 'B');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity for accessing an element in an array by index?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'A');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following statements about arrays is true?', 'Arrays can only store primitive data types', 'Arrays can store objects and primitive data types', 'Arrays can only store objects', 'Arrays cannot store anything', 'B');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following statements is true about the given code?', 'The code is correct and will work without any errors', 'The code is not correct and will throw an error', 'The index is out of bounds. It won''t throw an error but will print a garbage value', 'None of them', 'C');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the maximum number of dimensions an array can have in most programming languages?', '1', '2', '3', 'Unlimited', 'D');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In C/C++, how are arrays typically passed to functions?', 'By reference', 'By value', 'By pointer', 'By object', 'A');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity of inserting an element at the end of an array with no resizing required?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'A');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('How many elements does the following array have?', '0', '10', '9', '11', 'B');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the term for accessing elements of an array sequentially?', 'Random access', 'Traversal', 'Searching', 'Sorting', 'B');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the term for the process of finding the position of a specific element in an array?', 'Accessing', 'Indexing', 'Searching', 'Sorting', 'C');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a disadvantage of using arrays?', 'Dynamic size', 'Fixed data type', 'Efficient memory usage', 'Slow access to elements', 'B');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following statements about arrays is true?', 'Arrays are resizable', 'Arrays can contain elements of different data types', 'Arrays have a fixed size', 'Arrays are always sorted', 'C');

INSERT INTO swe_assign2.array (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following statements about multidimensional arrays is true?', 'Multidimensional arrays can have different data types in each dimension.', 'Multidimensional arrays are always rectangular.', 'Multidimensional arrays cannot be passed to functions in most programming languages.', 'Multidimensional arrays can have varying lengths in each dimension.', 'D');












CREATE TABLE swe_assign2.queue (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What data structure adheres to a First-In-First-Out (FIFO) principle?', 'Stack', 'Queue', 'Tree', 'Linked List', 'B');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What operation inserts a new element at the back of a queue?', 'Peek', 'Pop', 'Enqueue', 'Remove', 'C');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What operation removes and returns the element at the front of a queue?', 'Push', 'Insert', 'Dequeue', 'Peek', 'D');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the space complexity of a queue implemented using an array?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'C');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('A queue implemented with a linked list has what average time complexity for enqueue and dequeue operations?', 'O(1)', 'O(log n)', 'O(1)', 'O(n)', 'C');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which situation benefits most from using a queue data structure?', 'Storing a list of tasks prioritized by importance', 'Undoing multiple actions in an editor', 'Processing items on a first-come, first-served basis', 'Implementing dynamic sorting algorithms', 'C');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the underlying principle behind waiting lines or customer service queues?', 'Stack', 'Queue', 'Tree', 'Linked List', 'B');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('A circular queue uses what concept to avoid overflow when nearing the end of the allocated space?', 'Dynamic resizing', 'Linked list implementation', 'Wrapping around to the beginning', 'Stack-based overflow prevention', 'C');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What can be used to implement a queue data structure?', 'Only an array', 'Only a linked list', 'Both an array and a linked list', 'Neither an array nor a linked list', 'C');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the advantage of using an array to implement a queue?', 'More memory efficient', 'Faster access to front and back elements', 'Easier to implement dynamic resizing', 'Can store different data types in the same queue', 'B');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the disadvantage of using a linked list to implement a queue?', 'Faster access to front element', 'More memory overhead', 'More efficient for circular queues', 'Difficult to implement dequeue operation', 'B');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is an overflow condition in a queue?', 'Accessing an empty queue', 'Adding an element when the queue is full', 'Removing an element when the queue is empty', 'Both a and b', 'B');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('How can overflow in a circular queue be prevented?', 'Ignoring it, as it rarely occurs', 'Tracking empty and full positions within the array', 'Using a dynamically resizing array', 'All of the above', 'D');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is an underflow condition in a queue?', 'Adding an element when the queue is full', 'Removing an element when the queue is empty', 'Accessing an empty queue', 'Both a and c', 'B');

INSERT INTO swe_assign2.queue (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('How can underflow in a queue be prevented?', 'Ignoring it, as it rarely occurs', 'Checking for empty queue before dequeue', 'Using a circular queue implementation', 'Both b and c', 'D');









CREATE TABLE swe_assign2.stack (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What data structure adheres to a Last-In-First-Out (LIFO) principle?', 'Queue', 'Linked List', 'Stack', 'Tree', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What operation removes and returns the top element from a stack?', 'Push', 'Peek', 'Pop', 'Insert', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What operation adds a new element to the top of a stack?', 'Retrieve', 'Push', 'Remove', 'Insert', 'B');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the space complexity of a stack implemented using an array?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('A stack implemented with a linked list has what average time complexity for push and pop operations?', 'O(1)', 'O(1)', 'O(log n)', 'O(n)', 'B');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which situation benefits most from using a stack data structure?', 'Storing a list of tasks with deadlines', 'Navigating a website in chronological order', 'Undoing multiple actions in an editor', 'Sorting elements efficiently', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the underlying principle behind function calls in a computer program?', 'Queue', 'Linked List', 'Stack', 'Tree', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('A recursive function call effectively creates what data structure on the memory stack?', 'Queue', 'Array', 'Linked List', 'Stack', 'D');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What can be used to implement a stack data structure?', 'Only an array', 'Only a linked list', 'Both an array and a linked list', 'Neither an array nor a linked list', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the advantage of using an array to implement a stack?', 'Dynamic resizing is easier', 'More memory efficient', 'Faster access to top element', 'Can store different data types in the same stack', 'C');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the disadvantage of using a linked list to implement a stack?', 'Slower access to top element', 'More memory overhead', 'Easier to implement', 'Not suitable for large stacks', 'A');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is an overflow condition in a stack?', 'Accessing an empty stack', 'Adding an element when the stack is full', 'Removing an element when the stack is empty', 'Both a and b', 'D');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('How can overflow in a stack be prevented?', 'Ignoring it, as it rarely occurs', 'Using a dynamically resizing array', 'Checking for full stack before pushing', 'All of the above', 'D');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is an underflow condition in a stack?', 'Adding an element when the stack is full', 'Removing an element when the stack is empty', 'Accessing an empty stack', 'Both a and c', 'B');

INSERT INTO swe_assign2.stack (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('How can underflow in a stack be prevented?', 'Ignoring it, as it rarely occurs', 'Checking for empty stack before popping', 'Using a dynamically resizing array', 'Both b and c', 'D');








CREATE TABLE swe_assign2.linkedlist (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is a linked list?', 'A linear data structure', 'A non-linear data structure', 'A matrix data structure', 'A hierarchical data structure', 'A');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is not a type of linked list?', 'Singly linked list', 'Doubly linked list', 'Circular linked list', 'Binary linked list', 'D');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In a singly linked list, each node contains:', 'Data and pointer to the previous node', 'Data and pointer to the next node', 'Only data', 'Pointer to the head node', 'B');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following sorting algorithms can be used to sort a random linked list with minimum time complexity?', '(A) Insertion Sort', '(B) Quick Sort', '(C) Heap Sort', '(D) Merge Sort', 'D');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following operations cannot be performed efficiently on a singly linked list?', 'Insertion at the beginning', 'Insertion at the end provided we are given pointer of the end node', 'Deletion at the beginning', 'Deletion at the end', 'D');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In a circular linked list, how can you detect the end of the list during traversal?', 'By checking for NULL pointers', 'By checking for a specific flag value', 'By counting the number of nodes', 'By using a sentinel node', 'D');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity for searching an element in a singly linked list of ''n'' nodes in the worst case?', 'O(1)', 'O(n)', 'O(log n)', 'O(n^2)', 'B');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is an advantage of using a linked list over an array?', 'Random access of elements', 'Efficient memory utilization', 'Fixed size', 'Contiguous memory allocation', 'B');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the space complexity of a singly linked list?', 'O(1)', 'O(n)', 'O(log n)', 'O(n^2)', 'B');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In a circular linked list, the last node points to:', 'NULL', 'The first node', 'The middle node', 'The previous node', 'B');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which operation requires the least time complexity in a singly linked list?', 'Finding the length of the list', 'Insertion at the end of the list', 'Deleting the first node', 'Searching for a given element', 'C');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity to insert a node after a given node in a linked list?', 'O(1)', 'O(n)', 'O(log n)', 'O(n^2)', 'A');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Consider the following function to traverse a linked list. void traverse(struct Node head) { while (head->next != NULL) { printf("%d  ", head->data); head = head->next; } } Which of the following is FALSE about the above function?', 'The function may crash when the linked list is empty', 'The function doesn''t print the last node when the linked list is not empty', 'The function is implemented incorrectly because it changes head', 'None of the above', 'B');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What are the application(s) of linked list?', 'Implementation of stacks and queues.', 'Maintaining a directory of names', 'None of the above', 'Both a and b', 'D');

INSERT INTO swe_assign2.linkedlist (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In a singly linked list, how is the end of the list indicated?', 'By a NULL pointer in the last node', 'By a pointer to the first node', 'By a special marker node', 'By a counter variable indicating the list size', 'A');











CREATE TABLE swe_assign2.binary_search (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity of the binary search algorithm?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'B');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Binary search can only be applied to:', 'Unsorted arrays', 'Sorted arrays', 'Linked lists', 'Hash tables', 'B');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In binary search, the array must be sorted in which order?', 'Descending order', 'Ascending order', 'Random order', 'Any order', 'B');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Binary search repeatedly divides the search interval in half. What is the key idea behind this?', 'Divide and conquer', 'Linear exploration', 'Random search', 'Heuristic search', 'A');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the worst-case scenario for binary search?', 'The element being searched is the first element in the array.', 'The element being searched is in the middle of the array.', 'The element being searched is not in the array.', 'The element being searched is the last element in the array.', 'C');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following data structures is commonly used to implement binary search?', 'Queue', 'Stack', 'Array', 'Binary tree', 'C');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In binary search, if the middle element is equal to the target value, what happens next?', 'The search ends successfully.', 'The search continues in the left half of the array.', 'The search continues in the right half of the array.', 'None of the above.', 'A');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In binary search, what happens if the target value is less than the middle element?', 'The search ends unsuccessfully.', 'The search continues in the left half of the array.', 'The search continues in the right half of the array.', 'None of the above.', 'B');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In binary search, what happens if the target value is greater than the middle element?', 'The search ends unsuccessfully.', 'The search continues in the left half of the array.', 'The search continues in the right half of the array.', 'None of the above.', 'C');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is true about binary search?', 'It is suitable for searching in unsorted arrays.', 'It has a linear time complexity.', 'It requires the elements to be sorted.', 'It is less efficient than linear search.', 'C');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the primary advantage of binary search over linear search?', 'Binary search requires fewer comparisons.', 'Binary search works for unsorted arrays.', 'Binary search is easier to implement.', 'Binary search has a better average-case time complexity.', 'A');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Binary search is not suitable for:', 'Searching elements in a linked list.', 'Searching elements in a sorted array.', 'Searching elements in a binary search tree.', 'Searching elements in a hash table.', 'A');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In binary search, if the element being searched for is found at the first position of the array, how many comparisons will be made in the worst-case scenario?', '0', '1', 'Equal to the size of the array', 'Half the size of the array', 'B');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following statements is true about binary search?', 'Binary search has a time complexity of O(n).', 'Binary search can only be applied to arrays with an odd number of elements.', 'Binary search always requires the array to be sorted.', 'Binary search is inefficient for large datasets.', 'C');

INSERT INTO swe_assign2.binary_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In binary search, what is the best-case time complexity?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'A');












CREATE TABLE swe_assign2.linear_search (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity of the linear search algorithm?', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In which data structure is linear search commonly used?', 'Stack', 'Queue', 'Array', 'Binary Tree', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Linear search is also known as:', 'Binary search', 'Sequential search', 'Quick search', 'Divide and conquer search', 'B');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In linear search, the elements are searched:', 'Randomly', 'Sequentially', 'By jumping directly to the middle', 'None of the above', 'B');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the worst-case scenario for linear search?', 'The element being searched is the first element in the array.', 'The element being searched is in the middle of the array.', 'The element being searched is not in the array.', 'The element being searched is the last element in the array.', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a disadvantage of linear search?', 'It requires the array to be sorted.', 'It has a time complexity of O(log n).', 'It is not efficient for large datasets.', 'It always requires fewer comparisons compared to other searching algorithms.', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In linear search, the average case time complexity is:', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In linear search, if the element is found at the last position of the array, how many comparisons will be made in the worst-case scenario?', '0', '1', 'Equal to the size of the array', 'Twice the size of the array', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Linear search is efficient for searching in:', 'Sorted arrays', 'Unsorted arrays', 'Linked lists', 'Trees', 'B');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is true about linear search?', 'It is an efficient algorithm for searching in large datasets.', 'It can only be used on arrays with a fixed size.', 'It is easy to implement and understand.', 'It always requires the array to be sorted.', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Linear search is suitable for:', 'Searching elements in a sorted array', 'Searching elements in a balanced binary search tree', 'Searching elements in an unsorted array', 'Searching elements in a hash table', 'C');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In linear search, if the element being searched for is found in the first position of the array, how many comparisons will be made in the worst-case scenario?', '0', '1', 'Equal to the size of the array', 'Half the size of the array', 'B');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Linear search is also known as brute force search because:', 'It uses brute force to search for elements.', 'It is inefficient compared to other search algorithms.', 'It always requires the array to be sorted.', 'It is the fastest search algorithm.', 'A');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Linear search is suitable for:', 'Searching in a binary search tree', 'Searching in a graph', 'Searching in a sorted array', 'Searching in a singly linked list', 'D');

INSERT INTO swe_assign2.linear_search (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In linear search, the best-case time complexity is:', 'O(1)', 'O(log n)', 'O(n)', 'O(n^2)', 'A');













CREATE TABLE swe_assign2.insertion_sort (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the primary purpose of insertion sort?', 'To sort elements in ascending order', 'To randomly rearrange elements', 'To reverse the order of elements', 'To remove duplicate elements', 'A');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In insertion sort, where does the algorithm start sorting from initially?', 'Beginning of the list', 'End of the list', 'Middle of the list', 'Random position in the list', 'A');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm builds the sorted array one element at a time by repeatedly taking the next element and inserting it into the sorted portion of the array?', 'Quick sort', 'Merge sort', 'Insertion sort', 'Bubble sort', 'C');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity of the insertion sort algorithm in the worst-case scenario?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(n log n)', 'C');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which scenario would result in the best-case time complexity for insertion sort?', 'When the list is already sorted', 'When the list is sorted in descending order', 'When the list contains random elements', 'When the list is empty', 'A');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Insertion sort is efficient for sorting small lists or for which other type of lists?', 'Lists that are already partially sorted', 'Lists with random elements', 'Lists with a large number of elements', 'Lists with duplicate elements', 'A');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a disadvantage of insertion sort compared to other sorting algorithms?', 'It has a higher time complexity', 'It is not stable', 'It is difficult to implement', 'It cannot handle large datasets', 'A');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In insertion sort, after the first pass, how many elements are considered to be in the sorted portion of the list?', '0', '1', 'n-1', 'n', 'B');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm is often compared with insertion sort due to their similar efficiency on small datasets?', 'Merge sort', 'Quick sort', 'Bubble sort', 'Selection sort', 'D');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Insertion sort is an example of which sorting technique?', 'Divide and conquer', 'Greedy algorithm', 'Dynamic programming', 'Insertion method', 'D');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a common optimization technique for insertion sort?', 'Using recursion', 'Randomizing the list before sorting', 'Starting from both ends of the list', 'Early termination if the list is nearly sorted', 'D');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In insertion sort, what happens if the element to be inserted is smaller than all elements in the sorted portion of the list?', 'It is placed at the beginning of the list', 'It is placed at the end of the list', 'It is placed in its correct position within the sorted portion of the list', 'It is ignored', 'A');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm performs better for large datasets compared to insertion sort?', 'Bubble sort', 'Quick sort', 'Selection sort', 'Insertion sort', 'B');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the space complexity of the insertion sort algorithm?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(1)', 'D');

INSERT INTO swe_assign2.insertion_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following data structures is often used to implement insertion sort efficiently?', 'Array', 'Linked list', 'Stack', 'Queue', 'A');













CREATE TABLE swe_assign2.merge_sort (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the primary purpose of merge sort?', 'To sort elements in ascending order', 'To randomly rearrange elements', 'To reverse the order of elements', 'To remove duplicate elements', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In merge sort, how does the algorithm divide the list for sorting?', 'Into two halves', 'Into three equal parts', 'Randomly', 'Into smaller and smaller segments until they''re individually sorted', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm divides the unsorted list into n sublists, each containing one element, and then repeatedly merges sublists to produce new sorted sublists until there is only one sublist remaining?', 'Quick sort', 'Bubble sort', 'Merge sort', 'Insertion sort', 'C');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity of the merge sort algorithm in the worst-case scenario?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(n log n)', 'D');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which scenario would result in the best-case time complexity for merge sort?', 'When the list is already sorted', 'When the list is sorted in descending order', 'When the list contains random elements', 'When the list is empty', 'D');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Merge sort is known for its stability. What does stability mean in terms of sorting algorithms?', 'It ensures that duplicate elements remain in their original order', 'It ensures that the algorithm terminates early', 'It ensures that the algorithm doesn''t require additional memory', 'It ensures that the algorithm sorts the list quickly', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is an advantage of merge sort over other sorting algorithms?', 'It has a lower time complexity', 'It is easier to implement', 'It is not a comparison-based sorting algorithm', 'It performs well for large datasets', 'D');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In merge sort, what is the name of the process where the sorted sublists are combined back together?', 'Merging', 'Splitting', 'Inserting', 'Swapping', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm is often compared with merge sort due to their similar time complexity?', 'Bubble sort', 'Quick sort', 'Selection sort', 'Insertion sort', 'B');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Merge sort is an example of which sorting technique?', 'Divide and conquer', 'Greedy algorithm', 'Dynamic programming', 'Comparison-based sorting', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a common optimization technique for merge sort?', 'Using recursion', 'Randomizing the list before sorting', 'Starting from both ends of the list', 'Ignoring duplicate elements', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In merge sort, what is the time complexity of the merging step?', 'O(1)', 'O(log n)', 'O(n)', 'O(n log n)', 'C');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm performs better for large datasets compared to merge sort?', 'Bubble sort', 'Quick sort', 'Insertion sort', 'Selection sort', 'B');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the space complexity of the merge sort algorithm?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(1)', 'A');

INSERT INTO swe_assign2.merge_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following data structures is often used to implement merge sort efficiently?', 'Array', 'Linked list', 'Stack', 'Queue', 'A');













CREATE TABLE swe_assign2.bubble_sort (
    serial_no INT AUTO_INCREMENT PRIMARY KEY,
    question TEXT,
    optionA VARCHAR(255),
    optionB VARCHAR(255),
    optionC VARCHAR(255),
    optionD VARCHAR(255),
    Correct_Option VARCHAR(1)
);

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the primary purpose of bubble sort?', 'To sort elements in ascending order', 'To randomly rearrange elements', 'To reverse the order of elements', 'To remove duplicate elements', 'A');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In bubble sort, which adjacent elements are compared and swapped if they are in the wrong order?', 'First and last elements', 'Middle and last elements', 'Current and next elements', 'Random elements', 'C');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order?', 'Quick sort', 'Merge sort', 'Bubble sort', 'Insertion sort', 'C');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the time complexity of the bubble sort algorithm in the worst-case scenario?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(n log n)', 'C');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which scenario would result in the best-case time complexity for bubble sort?', 'When the list is already sorted', 'When the list is sorted in descending order', 'When the list contains random elements', 'When the list is empty', 'A');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Bubble sort is considered inefficient for large lists due to its:', 'Space complexity', 'Best-case time complexity', 'Worst-case time complexity', 'Stability', 'C');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a disadvantage of bubble sort compared to other sorting algorithms?', 'It is difficult to implement', 'It is not stable', 'It has a higher time complexity', 'It cannot handle large datasets', 'C');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In bubble sort, after the first pass, the largest element is guaranteed to be in its correct position. True or false?', 'True', 'False', '', '', 'A');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the number of passes required to sort an array of size n using bubble sort in the best-case scenario?', '1', 'n/2', 'n-1', 'n', 'A');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm is commonly used for educational purposes due to its simplicity?', 'Merge sort', 'Quick sort', 'Insertion sort', 'Bubble sort', 'D');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Bubble sort is an example of which sorting technique?', 'Divide and conquer', 'Dynamic programming', 'Greedy algorithm', 'Comparison-based sorting', 'D');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which of the following is a common optimization technique for bubble sort?', 'Randomizing the list before sorting', 'Starting from both ends of the list', 'Using recursion', 'Ignoring duplicate elements', 'B');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('In bubble sort, what happens if no swaps are made during a pass through the list?', 'The algorithm terminates', 'The next pass is skipped', 'The list is reversed', 'The largest element is removed', 'A');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('Which sorting algorithm performs better for large datasets compared to bubble sort?', 'Bubble sort', 'Quick sort', 'Insertion sort', 'Selection sort', 'B');

INSERT INTO swe_assign2.bubble_sort (question, optionA, optionB, optionC, optionD, Correct_Option)
VALUES ('What is the space complexity of the bubble sort algorithm?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(1)', 'D');