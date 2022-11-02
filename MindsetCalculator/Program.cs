using System;
using MindsetCalculator.Utilities;

namespace MindsetCalculator
{
    public class Program
    {
        static IQuestion[] questions = Array.Empty<IQuestion>();

        private static void AddQuestions()
        {
            questions.Append(new IQuestion(
                "Your intelligence is something very basic about you that you can't change very much",
                Point.GetPoints(0, 1, 2, 3)));
            questions.Append(new IQuestion(
                "No matter how much intelligence you have, you can always change it quite a bit",
                Point.GetPoints(3, 2, 1 ,0)));
            questions.Append(new IQuestion(
                "Only a few people will be truly good at sports, you have to be born with the ability",
                Point.GetPoints(0, 1, 2 ,3)));
            questions.Append(new IQuestion(
                "The harder you work at something, the better you will be",
                Point.GetPoints(3, 2, 1, 0)));
            questions.Append(new IQuestion(
                "I often get angry when I get feedback about my performance",
                Point.GetPoints(0, 1, 2, 3)));
            questions.Append(new IQuestion(
                "I appreciate when people, parents, coaches or teachers give me feedback about my performance",
                Point.GetPoints(3, 2, 1, 0)));
            questions.Append(new IQuestion(
                "Truly smart people do not need to try hard",
                Point.GetPoints(0, 1, 2, 3)));
            questions.Append(new IQuestion(
                "You can always change how intelligent you are",
                Point.GetPoints(3, 2, 1 ,0)));
            questions.Append(new IQuestion(
                "You are a certain kind of person and there is not much that can be done to really change that",
                Point.GetPoints(0, 1, 2, 3)));
            questions.Append(new IQuestion(
                "An important reason why I do my school work is that I enjoy learning new things",
                Point.GetPoints(3, 2, 1, 0)));
        }
        
        public static void Main(string[] args)
        {
            AddQuestions();

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Q: {questions[i]}");
            }
        }
    }
}