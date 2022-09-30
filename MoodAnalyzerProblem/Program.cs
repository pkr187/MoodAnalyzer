using MoodAnalyzerProblem;

Console.WriteLine("Welcome to Mood Analyze....!");
///Reads User's Mood.
Console.WriteLine("How is your Mood Happy or Sad...?");
string message = Console.ReadLine();
MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
Console.WriteLine(moodAnalyzer.AnalyseMood(message));