// Singleton Pattern
// This project aims to demonstrate a creation of an instance and avoid creating other instances
// This design would fail at having multiple threads and could possibly confuse itself, depending on if the program detects too much of all the threads
// This design would be good at having a access point to that one instance and has only one instance

using System;
using FinalProject;
using FinalProject.FinalProject;

Thread t1 = new Thread(() =>
{
    var instance = Uploadservice.Instance(1);
});

Thread t2 = new Thread(() =>
{
    var instance = Uploadservice.Instance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();