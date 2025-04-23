import 'dart:convert';
import 'package:http/http.dart' as http;
import '../models/lesson.dart';

class ApiService {
  static const String baseUrl = 'https://api.openai.com/v1';
  Future<List<Lesson>> fetchLessons() async {
    final response = await http.get(Uri.parse('$baseUrl/lessons'));
    if (response.statusCode == 200){
      List<dynamic> data = json.decode(response.body);
      return data.map((lesson) => Lesson.fromJson(lesson)).toList();
    }else{
      throw Exception('Failed to load lessons');
    }
  }
}