**1 - Why did you use inheritance?**

inheritance is the main way to use a single core in order to share the behavior between multiple objects. It basically makes a clear "Is A" relationship between the objects and makes it so that you don't need to rewrite the exact same code across the project



**2 - Why did you use interfaces?**

interfaces define what can and can't be done by an object. they force each object to share the same method names and inputs even if the code of the object is entirely different.





**3 - Can Helicopter inherit from both Vehicle and Airplane? Why or why not?**

nope, objects can only inherit \*ONE\* base class.



**4 - Why can Helicopter implement both IFlyable and IDriveable?**

because the way interfaces work make it so that IFlyable and IDrivable are simply blueprints of the methods and NOT the actual code itself.



**5 - If a Submarine can both sail and dive, how would you design it?**

i'd make submarine inherit Vehicle like everything else, and then like the other vehicles let it interface both ISailable and IDrivable.

