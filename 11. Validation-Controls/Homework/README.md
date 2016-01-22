# Validation Controls Homework
### Create a form to register users with fields for preferred user name, password, repeat password, first name, last name, age, email, local address, phone and an “I accept” option. 
- All fields are required. 
- Valid age is between 18 and 81. 
- Display error messages in a `ValidationSummary`. 
- Use a regular expression for the email and phone fields.
- Separate the fields in groups and validate them using Validation Groups. The Validation Groups should be at least three – Logon Info, Personal Info, Address Info.
- Add a radio button to choose the gender (male / female). If the user is male, dynamically display a list of check boxes for choosing his favourite cars (e.g. BMW, Toyota, etc.). If the user is female display a drop-down list to allow her select her favourite coffee (e.g. Lavazza, New Brazil, etc.). Note that selecting a coffee is optional for the female users. Implement this by server PostBacks.
- Implement the previous with client-side JavaScript.