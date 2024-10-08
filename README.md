# Old phone keypad
### Overview
This project aims for the Iron Software C# Coding Challenge.

## Project Requirements
an old phone keypad with alphabetical letters, a backspace key, and a send button.
Each button has a number to identify it and pressing a button
multiple times will cycle through the letters on it allowing each button to represent more than one letter.
For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.
You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.

## Test cases
Test case 1 :
Test Scenario: Input without # at the end of input.
Test Steps: input “33” => output: return '# must be end every input'.

Test case 2 :
Test Scenario: Pressing number once.
Test Steps: input “3#” => output: D

Test case 3 :
Test Scenario: Pressing number twice.
Test Steps: input “33#” => output: E

Test case 4 :
Test Scenario: Pressing number twice and delete once.
Test Steps: input “227*#” => output: B

Test case 5 :
Test Scenario: Pressing multi number.
Test Steps: input “4433555 555666#” => output: HELLO

Test case 6 :
Test Scenario: Pressing multi number and delete key.
Test Steps: input “8 88777444666*664#” => output: ?????
