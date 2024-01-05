# dynamic-terminal-menu
C# code for creating an interactive dynamic menu system for a terminal

## What is it?
For one of my Year 2 Uni projects, we were to create a CLI/Terminal application. I picked out creatinf a rental car system. I often wondered instead of waiting for a number input from a user and them selecting the wrong option, how about have an interactive menu like a GUI, but in the termnial. I also wanted to create something modular, this being the menu incase I wanted to use it elsewhere in the program.

## How it works
## Menu Function 
The ```Menu()``` function takes in:
- A dictionary of a key and value that are strings: ```Dictionary<string,string>```
- And makes use of C#'s actions: ```List<Action>```
This menu is responsible for keeping track of the users position, calling the additional ```Render()``` function and keeping track of user input. 

### Render Function
The render function takes in:
- The dictionary from the main which is made from a key and value that are strings ```Dictionary<string,string>```
- The position which is an ```int```

