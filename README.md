# _Word Counter_

#### _The program will tell you the total amount of times an inputted word is contained within an inputted sentence._

#### By _**Alex Williams**_

## Description

_The program starts by asking the user to input a word. The word is set to a string. The program then asks the user to input a sentence which is also set to a string._

_After the user inputs both, the program then checks to see how many times the word is contained within the sentence_

_**Example:**_

_User Word Input: "Dog"_

_User Word Sentence: "The Dog went to the Dog House to play with some Dogs and Doggies."_

_Expected Output: "The word Dog is used within the sentence 'The Dog went to the Dog House to play with some Dogs and Doggies.' 2 times._


## Specs

1. [_**Input: "a" and "a"- Expected Output: "1 Match"**_] User inputs the simplest string possible, in this case "a", and the program outputs that it matches once in the given string.
    
2. [_**Input: "a" and "a a" - Expected Output: "2 Matches"**_] User inputs the simplest string possible "a" and a string containing two a's, "a a". The program then outputs it has two matches.

3. [_**Input "dog" and "the dog likes to run in the dog park" - Expected Output: "2 Matches"**_] User inputs a string "dog" and a string containing multiple words containing multiple instances of the word "dog." The program then cycles through the string and finds two instances of the word "dog" and outputs that it has two matches.

4. [_**Input "cat" and "The cat likes to run with the other cats on the cathedral" - Expected Output: "1 Match"**_] User inputs a string "cat" and a string containing multiple words containing only one instance of the word "cat" but with other words CONTAINING the string "cat". Due to the way the program runs, only matching complete full word matches, the program should not match "cat" with either "cats" or "cathedral" and should only output that there is one match.

## Setup/Installation Requirements

Clone the Github Repository and run via git bash, or any other terminal.

https://github.com/Zizzs/csharp-word-counter

_No Databases or Servers are required._

## Known Bugs

_No known bugs._

## Support and contact details

_If you have any questions, or suggestions, please email me at Zizzs17@gmail.com or visit my Github repository at https://github.com/Zizzs_

## Technologies Used

_C# and .NET_

### License

*MIT License*

Copyright (c) 2018 **_Alex Williams_**