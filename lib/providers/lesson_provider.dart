import 'package:flutter/material.dart';
import '../models/lesson.dart';
import '../services/api_service.dart';

class LessonProvider with ChangeNotifier {
  List<Lesson> _lessons = [];
  bool _isLoading = false;

  List<Lesson> get lessons => _lessons;
  bool get isLoading => _isLoading;

  Future<void> loadLessons() async{
    _isLoading = true;
    notifyListeners();
    try{
      _lessons = await ApiService().fetchLessons();
    } catch (e) {
      print("Error fetching lessons: $e");
    }
    _isLoading = false;
    notifyListeners();
  }
}