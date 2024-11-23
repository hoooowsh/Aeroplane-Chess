using System;
using System.Collections.Generic;

namespace AeroplaneChessHelper;

public interface IDice
{
    public (int, string) Roll();
    public void InitDice(string[] lines);
}

public class Dice : IDice
{
    private int DiceNum;
    private List<string> DiceContent;
    private Random Rand;

    public Dice()
    {
        DiceContent = new List<string>();
        Rand = new Random();
    }

    public (int, string) Roll()
    {
        int randNum = Rand.Next(0, DiceNum);
        string diceContent = DiceContent[randNum];
        return (randNum, diceContent);
    }

    public void InitDice(string[] lines)
    {
        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                DiceContent.Add(line);
            }
        }
        DiceNum = DiceContent.Count;
    }
}