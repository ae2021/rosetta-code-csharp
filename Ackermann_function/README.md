# rosetta-code-csharp

Solutions for Rosetta Code in C# 

## 
[rosettacode.org/wiki/Ackermann_function](http://rosettacode.org/wiki/Ackermann_function)

The [Ackermann function](https://en.wikipedia.org/wiki/Ackermann_function) 
is a classic example of a recursive function, notable especially because it is not a primitive recursive function. It grows very quickly in value, as does the size of its call tree.

A ( m , n ) = 
{
	n + 1 if  m = 0 
	A ( m − 1 , 1 ) if  m > 0  and  n = 0 
	A ( m − 1 , A ( m , n − 1 ) ) if  m > 0  and  n > 0
}