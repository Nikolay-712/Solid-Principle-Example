﻿using LiskovSubstitutionPrinciple.Models;
using LiskovSubstitutionPrinciple.Services;

internal class Program
{
    //The Liskov Substitution Principle emphasizes that objects of a superclass should be replaceable with objects of its subclasses
    //without affecting the correctness of the program.
    //This means that the behavior of a subclass should not contradict the behavior of its superclass.

    private static void Main(string[] args)
    {
        BirdWatcher watcher = new BirdWatcher();

        Bird sparrow = new Sparrow();
        Bird penguin = new Penguin();

        watcher.WatchBird(sparrow); // Sparrow flies
        watcher.WatchBird(penguin); // Penguin walks
    }
}