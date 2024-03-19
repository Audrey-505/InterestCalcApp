﻿using InterestCalcApp;

namespace InterestCalcAppTests;

public class InterestCalcTests
{
    [Fact]
    public void PromptPrinciple_GetsDataBack()
    {
        InterestCalc app = new();
        string testInput = "200";
        var inputStream = new StringReader(testInput);
        Console.SetIn(inputStream);
        var userInput = app.PromptPrinciple();
        Assert.Equal(testInput, userInput);
    }

    [Fact]
    public void PromptIntrest_GetsDataBack()
    {
        InterestCalc app = new();
        string testInput = "13";
        var inputStream = new StringReader(testInput);
        Console.SetIn(inputStream);
        var userInput = app.PromptInterest();
        Assert.Equal(testInput, userInput);
    }

    [Fact]
    public void PromptLength_GetsDataBack()
    {
        InterestCalc app = new();
        string testInput = "5";
        var inputStream = new StringReader(testInput);
        Console.SetIn(inputStream);
        var userInput = app.PromptLength();
        Assert.Equal(testInput, userInput);
    }

    [Fact]
    public void ValidateInput_Principle()
    {
        InterestCalc app = new();
        var testInput = "200";
        var inputStream = new StringReader(testInput);
        Console.SetIn(inputStream);
        string response = app.PromptPrinciple();
        int parsedValue = app.ValidatePrinciple(response);
        Assert.Equal(200, parsedValue);
    }

    [Fact]
    public void ValidateInput_Interest()
    {
        InterestCalc app = new();
        var testInput = "13";
        var inputStream = new StringReader(testInput);
        Console.SetIn(inputStream);
        string response = app.PromptInterest();
        int parsedValue = app.ValidateInterest(response);
        Assert.Equal(13, parsedValue);
    }

    [Fact]
    public void ValidateInput_Length()
    {
        InterestCalc app = new();
        var testInput = "5";
        var inputStream = new StringReader(testInput);
        Console.SetIn(inputStream);
        string response = app.PromptLength();
        int parsedValue = app.ValidateLength(response);
        Assert.Equal(5, parsedValue);
    }
}
 