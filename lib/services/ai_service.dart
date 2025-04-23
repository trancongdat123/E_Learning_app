import 'dart:convert';
import 'package:http/http.dart' as http;

class AIService {
  static const String aiApiUrl = 'https://api.openai.com/v1/chat/completions';
  static const String apiKey = 'YOUR_OPENAI_API_KEY';

  Future<String> chatWithAI(String message) async {
    final response = await http.post(
      Uri.parse(aiApiUrl),
      headers: {
        'Authorization': 'Bearer $apiKey',
        'Content-Type': 'application/json',
      },
      body: jsonEncode({
        'model': 'gpt-3.5-turbo',
        'messages': [
          {'role': 'user', 'content': message}
        ],
      }),
    );
    if (response.statusCode == 200) {
      var data = json.decode(response.body);
      return data['choices'][0]['message']['content'];
    } else {
      throw Exception('Failed to get AI response');
    }
  }
}