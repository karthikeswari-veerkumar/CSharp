# CSharp

## Assignments for C# Fundamentals - Part2

### General Guidelines

All C# coding standards should be followed

Variable names must be meaningful. Avoid using names like a,b etc (except loop variables)

Important pieces of code must be documented

Unhandled exception should not be thrown

Program should respond properly for any input

### Assignment 1: Extract Bits

Get a number as input from user in command line

Get two input numbers – Start Bit and Stop Bit from the user

Convert the input number into Binary and extract the bits from Start Bit to Stop Bit of the number (consider LSB as starting bit and its starts from 0)

Display both the Binary and Decimal value of the extracted number

Ex: Input number -> 78, Start Bit -> 2, Stop Bit -> 5

Here Binary value = 1001110, Bit0 -> 0, Bit1 -> 1, Bit2 ->1. Bit3 -> 1, Bit4 -> 0, Bit5 -> 0, bit6 -> 1

Hence Bit5 to Bit2 is 0011, hence the output should be

Binary Field Value = 0011

Decimal Field Value = 3

### Assignment 2: Upper case conversion

Question

User needs to enter a string and a message should be shown for that

Each entered string must be converted to upper case

The converted string should be displayed with the message

“Case converted string is xxxxxxx”

After the above message, again step 1 should happen

The above steps should be repeated till user enters “stop” (stop can be case insensitive)

### Assignment 3: Print \* triangle

Question

Print a star like below \* \* \* \* \* \* \* \* \* \*

---

The number of rows (n) must be obtained from user

0 < n <= 10

For out of bounds value, a message must be shown saying the value is not in range
