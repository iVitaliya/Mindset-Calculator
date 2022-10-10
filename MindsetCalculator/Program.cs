namespace MindsetCalculator
{
    class Calculator
    {
        int points = 0;

        public Calculator(int points)
        {
            this.points = points;
        }


    }

    class IPoints
    {
        private int strongly_agree;
        private int agree;
        private int disagree;
        private int strongly_disagree;

        public IPoints(int strongly_agree, int agree, int disagree, int strongly_disagree)
        {
            this.agree = agree;
            this.disagree = disagree;
            this.strongly_agree = strongly_agree;
            this.strongly_disagree = strongly_disagree;
        }

        public int GetPoint(string type)
        {
            int res = 0;

            switch (type)
            {
                case "strongly_agree":
                    res = this.strongly_agree;
                    break;
                case "agree":
                    res = this.agree;
                    break;
                case "strongly_disagree":
                    res = this.strongly_disagree;
                    break;
                case "disagree":
                    res = this.disagree;
                    break;
            }

            return res;
        }
    }

    class IQuestions
    {
        private string question = string.Empty;
        private IPoints points;

        public IQuestions(string question, IPoints points)
        {
            this.question = question;
            this.points = points;
        }

        public string GetQuestion()
        {
            return this.question;
        }

        public IPoints GetPoints()
        {
            return this.points;
        }
    }

    class Program
    {
        static IQuestions[] questions = Array.Empty<IQuestions>();

        private static void AddQuestions()
        {
            questions.Append(new IQuestions(
                "Your intelligence is something very basic about you that you can't change very much",
                new IPoints(0, 1, 2, 3)));
            questions.Append(new IQuestions(
                "No matter how much intelligence you have, you can always change it quite a bit",
                new IPoints(3, 2, 1 ,0)));
            questions.Append(new IQuestions(
                "Only a few people will be truly good at sports, you have to be born with the ability",
                new IPoints(0, 1, 2 ,3)));
            questions.Append(new IQuestions(
                "The harder you work at something, the better you will be",
                new IPoints(3, 2, 1, 0)));
            questions.Append(new IQuestions(
                "I often get angry when I get feedback about my performance",
                new IPoints(0, 1, 2, 3)));
            questions.Append(new IQuestions(
                "I appreciate when people, parents, coaches or teachers give me feedback about my performance",
                new IPoints(3, 2, 1, 0)));
            questions.Append(new IQuestions(
                "Truly smart people do not need to try hard",
                new IPoints(0, 1, 2, 3)));
            questions.Append(new IQuestions(
                "You can always change how intelligent you are",
                new IPoints(3, 2, 1 ,0)));
            questions.Append(new IQuestions(
                "You are a certain kind of person and there is not much that can be done to really change that",
                new IPoints(0, 1, 2, 3)));
            questions.Append(new IQuestions(
                "An important reason why I do my school work is that I enjoy learning new things",
                new IPoints(3, 2, 1, 0)));
        }
        
        static void Main(string[] args)
        {
            AddQuestions();
        }
    }
}