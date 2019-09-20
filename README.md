# Polymorphismlab
## MathOperation
Create a class MathOperations, which should have 3 times method Add(). Method Add() has to be invoked with:</br>
•	Add(int, int): int</br>
•	Add(double, double, double): double</br>
•	Add(decimal, decimal, decimal): decimal</br>
Result
![TestOperation](./img/TestOperations.gif "Logo Operation 1")
## Animals
Create a class Animal, which holds two fields:</br>
•	name: string</br>
•	favouriteFood: string</br>
Animal has one virtual method ExplainSelf(): string.</br>
You should add two new classes - Cat and Dog. Override the ExplainSelf() method by adding concrete animal sound on a new line. (Look at examples below) </br>
Result</br>
![TestAnimals](./img/TestAnimals.gif "Logo Animals 1")
## Shapes
Create a class hierarchy, starting with abstract class Shape:</br>
•	Abstract methods:</br>
o	CalculatePerimeter(): doulbe</br>
o	CalculateArea(): double</br>
•	Virtual methods:</br>
o	Draw(): string</br>
Extend the Shape class with two children:</br>
•	Rectangle</br>
•	Circle</br>
Each of them need to have: </br>
•	Fields: </br>
o	height and width for Rectangle</br>
o	radius for Circle</br>
•	Encapsulation for these fields</br>
•	A public constructor </br>
•	Concrete methods for calculations (perimeter and area)</br>
•	Override methods for drawing </br>
Result</br>
![TestShapes](./img/TestShape.gif "Logo Shape 1")
