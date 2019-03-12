# H3 AI Value Evaluator
Experimental tool for Heroes of Might & Magic 3 modding. Uses machine learning to guess AI value for new creatures based on creature statistics.

## Repository content

Source code + sample data based on original H3 creatures - rows in order: attack power, defense power, speed, AI value. Attack power calculated as (min damage + max damage)/2 * (1 + 0.05 * creature attack). Defense power calculated as hitpoints * (1 + 0.05 * defense power). 

Built with Visual Studio 2017, machine learning implemented with preview version of ML.NET library.

## Copyright and license

H3 AI Value Evaluator is licensed under General Public License version 2.

Copyright (C) 2019 Dydzio