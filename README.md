# Word Counter

#### A MVC app that checks how many times a selected word is in a sentence entered by the user. 10/20/17

#### By **Marcus Parmentier**

## Description

A MVC app created with C Sharp and use of Razor and .NET framework focusing on creating objects with a custom class and constructor, using RESTful route conventions using HttpGet and HttpPost, and routes to specific instance of the object. Also with a focus on BDD and the use of MS Testing.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **1st: Program returns word count after user enters a word. (This is the most basic example)** | User input: " 'Search word: word', 'Sentence to check in: word' " | Output: "1" |
| **2nd: Program returns word count after user enters a phrase. (This is the most basic example that includes the previous spec's functionality and ignores capitalization in the check phrase)** | User input: " 'Search word: Word', 'Sentence to check in: worD' " | Output: "1" |
| **3rd: Program returns word count after user enters a phrase. (This is the most basic example that includes the previous spec functionalities and has more than two words in the check phrase)** | User input: " 'Search word: wordS', 'Sentence to check in: Words to check' " | Output: "1" |
| **4th: Program returns word count after user enters a phrase. (This is the most basic example that includes the previous spec functionalities and will check if the program is adding correctly)** | User input: " 'Search word: Word', 'Sentence to check in: word Word woRd wOrD' " | Output: "4" |
| **5th: Program returns word count after user enters a phrase. (This is the most basic example that includes the previous spec functionalities and ignores punctuation)** | User input: " 'Search word: word', 'Sentence to check in: Word, words. woRd: WORDS & WORD!' " | Output: "3" |


## Setup/Installation Requirements

* Clone project from GitHub
* Have .NET Core 1.1.4 downloaded
* Restore and run project while in the project in your terminal

## Known Bugs

* N/A

## Technologies Used

* C Sharp
  * .Net Core
  * Razor

## Support and contact details

_Email me at marcusjparmentier@gmail.com with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2017 **_{Marcus Parmentier}_**
