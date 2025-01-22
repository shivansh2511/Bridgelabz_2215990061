using System;
class FindAverage{
static void Main(string [] args){
int marksMaths = 94;
int marksPhysics = 95;
int marksChemistry = 96;
double avgMarks = (marksMaths + marksPhysics + marksChemistry) / 3;
double avgMarksPercent = (avgMarks/100)*100;
Console.WriteLine("Sam's Average Marks Percent in PCM is "+avgMarksPercent);
}
} 