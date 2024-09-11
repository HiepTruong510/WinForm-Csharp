**Forms and common Controls**  

**Test1: Using Form and Button**  
The Form design has two command buttons named &Green and &Yellow. The Form has Min and Max Buttons.  
- When clicking on the Green command button, the Form changes the background color to Green and changes the Form title to “Green Color”.  
- When clicking on the Yellow command button, the Form changes the background color to Yellow and changes the Form title to “Yellow Color”.  

**Test2: Using Form, TextBox and Button**  
The Form design has a blank TextBox, and 3 command buttons: Display, Clear, Exit.  
- When you click the Display button, the TextBox will display the sentence: "Welcome to the C# programming language".  
- Click the Clear button, the TextBox will be cleared.  
- Click the Exit button to exit the program.  

**Test3: Using Form, TextBox, Label and Button**  
The Form design has a TextBox (can type multiple lines), a Label, 1 View command button, 1 Exit command button to perform the following tasks:  
- Initially, the View button is dimmed, when you start pressing any key on the TextBox, the View button is activated.  
- After entering the TextBox, click the View button, the Label will display the content of the TextBox.  
- Click the Exit button to exit the program.  

**Test4: Using Forms, Labels, Groupboxes and RadioButtons**  
The Form design includes 1 Label with the text “What is the MultiLine attribute for?” and 4 RadioButtons with the following titles: Bold, Italic, Line Break, Uppercase. The RadioButtons are placed in a Groupbox labeled “Answer”. Finally, there is a Label to display the results. The tasks to be performed:  
- Initially, the Label displaying the results is empty.  
- When the 3rd RadioButton is selected, the Result Label displays the text “Correct”.  
- When the remaining RadioButtons are selected, the Result Label displays the text “Incorrect”.  

**Test5: Using Form, Label, Groupbox and CheckBox**  
The Form design includes 1 Groupbox labeled “Choose your favorite Vietnamese singers”, containing 5 CheckBoxes labeled respectively: My Tam, My Linh, Thanh Lam, Quang Dung, Lam Truong, 1 “View” command button and a Label to display the list of your favorite singers. Tasks to be performed:  
- If no singer is selected, the Label will display the content “You did not select any singer in the above list”.  
- If selected, the Label will display the content: “Your favorite singers are” <list of singers>.  

**Test6: Using Form, TextBox and ListBox**  
The Form design includes 1 ListBox and 1 TextBox. When clicking on the elements in the ListBox, the TextBox will display the content of the selected elements.  

**Test7: Using Form, ListBox and Button**  
The Form design includes 2 ListBoxes, 2 Labels and 4 command buttons with the following interface:  
- Select items on the "List of items" side, when clicking on the > button, the selected elements will be moved to the "Selected items" side, (and at the same time delete the selected elements on the "List of items").  
- When clicking on the >> button, all elements on the "List of items" side will be moved to the "Selected items" side, (and at the same time delete the "List of items").  
- Select items on the "Selected items" side, when clicking on the < button, the selected elements will be moved to the "List of items" side, (and at the same time delete the selected elements on the "Selected items" side).  
- When clicking on the << button, all elements on the "Selected items" side will be moved to the "List of items" side, (and delete the selected elements on the "Selected items" side).  

**Test8: Using Form, TextBox, ComboBox and Button**  
The Form design includes 1 TextBox to fill in Full Name, 3 ComboBoxes with accompanying Labels: Day, Month, Year.  
- The Day ComboBox loads values ​​from 1 to 31 (no additional data allowed).  
- The Month ComboBox loads values ​​from 1 to 12 (no additional data allowed).  
- The Year ComboBox loads values ​​from 1930 to 2010 (additional data allowed).  
When pressing the Check command button, if the date of birth is valid, a MessageBox will appear notifying Full Name and Date of Birth. If the date data is invalid, a MessageBox will appear notifying “Invalid Date of Birth!”.  

**Test9: Design a simple Calculator program**  
- TextBox A+B, A*B, A-B, A/B are not allowed to edit data (ReadOnly property = True).  
- After entering data for A and B, if the data is entered in the correct numeric format, when pressing the Result button, the result will be calculated to fill in TextBox A+B, A-B, A*B, A/B.  
- Pressing the Reset button will clear all TextBoxes, returning Focus to TextBox A.  
- Press the Exit button to exit the program.  
Note: Create TabIndex in order: TextBox A, TextBox B, Result button, Reset button, Exit button.  
