namespace AsistenteFinancieroAPI.Models
{
    public class ChatResponse
    {
        public string Message { get; set; } = string.Empty;

        public string RecommendedProduct { get; set; } = string.Empty;

        public Simulation? Simulation { get; set; }

        public string Cta { get; set; } = "Ir a Aportar";

        public bool ShowCta { get; set; } = true;

        public bool SpeakResponse { get; set; } = true;
    }

    public class Simulation
    {
        public decimal MonthlyAmount { get; set; }

        public int Months { get; set; }

        public decimal EstimatedSavings { get; set; }
    }
}
