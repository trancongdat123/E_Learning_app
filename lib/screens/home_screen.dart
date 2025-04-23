import 'package:flutter/material.dart';
import 'lesson_screen.dart';
import 'chat_ai_screen.dart';

class HomeScreen extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('E-Learning English')),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            ElevatedButton(
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(builder: (context) => LessonScreen()),
                );
              },
              child: Text('Bắt đầu học'),
            ),
            SizedBox(height: 20),
            ElevatedButton(
              onPressed: () {
                Navigator.push(
                  context,
                  MaterialPageRoute(builder: (context) => ChatAIScreen()),
                );
              },
              child: Text('Luyện nói với AI'),
            ),
          ],
        ),
      ),
    );
  }
}
