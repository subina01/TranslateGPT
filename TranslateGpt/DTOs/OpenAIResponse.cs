namespace TranslateGpt.DTOs
{
    public class OpenAIResponse
    {
        public string? Id { get; set; }  
        public string? Object { get; set; }
        public int Created { get; set; }
        public int Model { get; set; }

        public List<Choice>? Choices { get; set; }

    
   }
    public class Choice
    {
        public int Index { get; set; }

        public Message? Message { get; set; }

        public string? FinishReason { get; set; }


    }

    public class Message
    {
        public string? Role { get; set; }
        public string? Content { get; set; }
    }

}
