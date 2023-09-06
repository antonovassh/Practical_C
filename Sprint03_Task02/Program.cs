﻿//using System.Collections.Generic;

//Define a class StringExtensions with an extension method WordCount(…) for class String that counts the number of words in a given string. 

//Notes. 

// 1. The 'word' means the sequence of letters, digits, and service symbols, which are limited by a space or punctuation symbol.
//2. Try to use string.Split() method and pass array of delimiters (' ', '.', '?', '!', '-', ';', ':', ',') as the first parameter. 

public static class StringExtensions
{
    public static int WordCount(this string input)
    {
        return input.Split(new[] { ' ', '.', '?', '!', '-', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

}