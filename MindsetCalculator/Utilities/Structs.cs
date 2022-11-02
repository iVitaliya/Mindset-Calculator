namespace MindsetCalculator.Utilities
{
    struct IPoint
    {
        private int strongly_agree;
        private int agree;
        private int disagree;
        private int strongly_disagree;

        public IPoint(int strongly_agree, int agree, int disagree, int strongly_disagree)
        {
            this.strongly_agree = strongly_agree;
            this.agree = agree;
            this.disagree = disagree;
            this.strongly_disagree = strongly_disagree;
        }
    }

    struct IQuestion
    {
        private string question;
        private IPoint points;

        public IQuestion(string question, IPoint points)
        {
            this.question = question;
            this.points = points;
        }

        public string GetQuestion()
        {
            return this.question;
        }

        public IPoint GetPoints()
        {
            return this.points;
        }
    }

    class Point
    {
        public static IPoint GetPoints(int strongly_agree, int agree, int disagree, int strongly_disagree)
        {
            return new IPoint(
                strongly_agree: strongly_agree,
                agree: agree,
                disagree: disagree,
                strongly_disagree: strongly_disagree
            );
        }
    }
}