# ipChallenge

Coding problem
Please answer the following problem using Javascript, C#, or any programming
language you are comfortable with. Please do not spend more than 1-2 hours on
coding time.
When provided with a string of digits, find all sequential subdivisions of the data
which are valid IP addresses. The results can be in any order.
IP addresses must follow the format A.B.C.D where A, B, C, D are numbers between
0 and 255. Leading zeros, such as 01 or 065 are invalid, except for the value 0 itself.
parse("1234") => [ '1.2.3.4' ]
parse("12340") => [ '1.2.3.40', '1.2.34.0', '1.23.4.0', '12.3.4.0' ]
parse("1542510123") => [ '154.25.10.123', '154.251.0.123',
'154.25.101.23' ]
Please explain how you would test this algorithm. How does the testing strategy
change if this algorithm is only called internally by trusted programmers, versus
exposing this algorithm to the open web for anyone to call?
Tell us what kind of issues you ran into writing the code and making the tests, and
discuss how you debugged and resolved the issues.
Problem
Examples:
Testing
Discussion
