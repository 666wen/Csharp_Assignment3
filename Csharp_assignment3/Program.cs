/*
1. What are the six combinations of access modifier keywords and what do they do? 
ANS: public static -- can be accessed by other class and belong to the type itself.
     private static -- can be accessed inside the class and belong to the type itself.
     public abstract --can be accessed by other class and do not provide an implementation.
     private abstract --can be accessed inside class and could not provide an implementation in derived class.
     public virtual --can be accessed by other class and can have an implementation and provide the derived classes with the OPTION of overriding it.
     private virtual --can be accessed inside class and can have an implementation, could not overriding it in derived class.

2.What is the difference between the static, const, and readonly keywords when applied to a type member?
ANS: const -- immutable values which are known at compile time and do not change for the life of the program.
     readonly-- indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class.
     static -- belong to the type itself rather than to a specific object.

3. What does a constructor do?
ANS: constructor is used to create an object of the class and initialize class members.

4. Why is the partial keyword useful?
ANS: 

5. What is a tuple?
ANS: a data structure which gives the easiest way to represent a data set which has multiple values. 

6. What does the C# record keyword do?
ANS: to define a reference type that provides built-in functionality for encapsulating data.

7. What does overloading and overriding mean?
ANS: method overriding: happens between base class and the derived class; same method signature;
                        derived class can have different implementations for the same methods -- runtime polymorphism
    method overloading: multiple methods in the same class, with same method name and access modifiers, 
                        but different input or output parameter -- compile time polymorphism.

8. What is the difference between a field and a property?
ANS: A field is a variable of any type that is declared directly in a class. 
     A property is a member that provides a flexible mechanism to read, write or compute the value of a private field.

9. How do you make a method parameter optional?
ANS: BY overloading the method with different parameter list.

10. What is an interface and how is it different from abstract class?
ANS: Interface is a collection of methods which are by default abstract and public, and will be implemented by the derived class.

11. What accessibility level are members of an interface?
ANS: public abstract

12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
ANS: True

13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
ANS: True

14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
ANS:False

15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
ANS: False

16. True/False. Normal (non-abstract) methods can be used in an abstract class. 
ANS: True

17. True/False. Derived classes can override methods that were virtual in the base class.
ANS: True

18. True/False. Derived classes can override methods that were abstract in the base class. 
ANS: True

19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.
ANS: False

20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
ANS: False

21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
ANS: True

22. True/False. A class can have more than one base class.
ANS: False

23. True/False. A class can implement more than one interface.
ANS: True

 */






/*----------------------(1)----------------------------*/

using Csharp_assignment3;
/*
ArrayReverse arr = new ArrayReverse(10);
int[] numbers = arr.GenerateNumbers();
arr.Reverse(numbers);
arr.PrintNumber(numbers);


/*---------------------(2)----------------------------*/
/*

for (int i = 1; i < 11; i++)
{
    int fib = Fibonacci.GenerateFibo(i);
    Console.WriteLine(fib);
}
*/

/*-----------------Designing and Building class using OOP--------------*/

/*----------------------(7)-------------------------------*/
Color c1 = new Color(2, 4, 100);
Ball ball1 = new Ball(2, c1);

Color c2 = new Color(22, 4, 10);
Ball ball2 = new Ball(2, c2);

Color c3 = new Color(26, 44, 50);
Ball ball3 = new Ball(2, c3);

ball1.Throw();
ball2.Throw();
ball3.Throw();
ball1.Throw();
ball2.POP();
ball2.Throw();
Console.WriteLine(ball1.ThrowCount);
Console.WriteLine(ball2.ThrowCount);
Console.WriteLine(ball3.ThrowCount);
