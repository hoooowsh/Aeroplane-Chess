using System;
using System.IO;

namespace AeroplaneChessHelper;

public interface IFileScanner
{
    public Dice ScanDiceFile();
}

public class FileScanner : IFileScanner
{
    private string DiceFileAssetPath = "../Assets/dice.txt";
    private string MapFileAssetPath = "../Assets/map.txt";

    public Dice ScanDiceFile()
    {
        string[] lines = File.ReadAllLines(DiceFileAssetPath);
        Dice dice = new Dice();
        dice.InitDice(lines);
        return dice;
    }
}