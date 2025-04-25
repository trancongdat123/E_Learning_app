namespace E_Learning_API.Services
{
    public class AIService : IAIService {
        public string GenerateResponse(string input){
            return "$AI response for : {input}";
        }
    }
}