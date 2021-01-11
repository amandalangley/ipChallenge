# ipChallenge

Coding problem <br />
Please answer the following problem using Javascript, C#, or any programming
language you are comfortable with. Please do not spend more than 1-2 hours on
coding time. <br />
When provided with a string of digits, find all sequential subdivisions of the data
which are valid IP addresses. The results can be in any order. <br />
IP addresses must follow the format A.B.C.D where A, B, C, D are numbers between
0 and 255. Leading zeros, such as 01 or 065 are invalid, except for the value 0 itself. <br />
parse("1234") => [ '1.2.3.4' ] <br />
parse("12340") => [ '1.2.3.40', '1.2.34.0', '1.23.4.0', '12.3.4.0' ] <br />
parse("1542510123") => [ '154.25.10.123', '154.251.0.123',
'154.25.101.23' ] <br />
Please explain how you would test this algorithm. How does the testing strategy 
change if this algorithm is only called internally by trusted programmers, versus
exposing this algorithm to the open web for anyone to call? <br />
Testing
- with Trusted programmers would not worry as much about user input like special characters 
- take a break from working on the code to get into a testing mindset.
- make a list of happy path solutions, also validate given test cases
- make a list of edge cases
    - particularly with zeros
    - whitespace
    - 255255255255 0000
    - 256, negative 1
    - ensure valid single 0 possibilities
    - LEADING ZEROS
        - 01255255255 (leading 0 in beginning only possibility)
        - 25501255255 (second spot 01)
        - 25525501255 (thirst spot 01)
        - 25525525501 (fourth spot 01)
- make a list of breaking cases
    - Too short
    - Too long
    - Non digit characters

Tell us what kind of issues you ran into writing the code and making the tests, and
discuss how you debugged and resolved the issues. <br />
Figuring out that I needed to remove the last added portion in order to use the recursive function without getting duplicate entries <br />
for example, figuring out how to maintain the ipAddressBuilder and update it as needed when adding elements. To not destroy too much while maintaining a copy of the current position of ipAddress with the data <br />
