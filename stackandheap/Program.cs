// stack and heap memory allocation in C#

// stack is for value types which are stored directly in the stack frame 
// while heap is for reference types which are stored in the heap memory


using System;

int testValue = 4;
byte lowLevelValue = 3;
bool booleanValue = false;
string stringValue = "Hello, World!";

StackHeapExample stackHeap = new StackHeapExample();
stackHeap.AddFive(5);
