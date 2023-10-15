# Algorithms using C#, .NET 7.0 Isolated Azure Functions

A repository with a collection of data structures, algorithms and some leetcode questions done using Azure Functions to make running problems easier. 

Each problem is encapsulated as a function with HTTP trigger, with an openAPI page. These functions can then be run from within that interface showcasing both openAPI integration along with Algorithms, Data Structures, Graph Algorithms and some leetcode problems re-inforcing Computer Science fundamentals. 

PS: There will be more repositories in some of my favorite languages including Python, Go, Rust, Java, C and Typescript (Sorry Javascript fans)

## Quick Start

The code in this repository can be run on Windows, Linux and MacOS hosts as long as .Net 7.0 is installed and it can be easily installed by using your Operating System's package manager (Yes! Windows has one and its called winget and or using Chocolatey).

This repository comes with devcontainer template with dependencies mentioned in the config file under '.devcontainer' folder, which builds a docker image locally can be run locally either on WSL or POSIX systems. 

## Why Azure Functions ?

Azure Functions is the choice of platform for this implementation because its quite easy to get it up and running because each individual function can be run from its own class (as long as they methods are static) much like web frameworks but still getting the Strong Type Checking availble with C# and along the way learn more on how to implement .NET. 

This kind of project offers using dotnet more in a functional and OOP manner, allows us to experiment with .NET specific technolgies like Modelling Framework to maintain database bindings (gloried ORM). 

## OpenAPI Integration

Azure Functions has great OpenAPI integration where its easy to invoke the functions using HTTP triggers and thus making debugging easy.

## What kind of problems are solved under this repository ?

From basic data structures like Arrays, Linked Lists, Queues, Stacks, Trees and Trie all the way to some graph algorithms, dynamic programming and some leetcode problems. 
