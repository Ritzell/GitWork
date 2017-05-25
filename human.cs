using System;

interface IHuman{
  void Walk(float speed);
  void Speak(string text);
  string listen();
  void Run(float speed);
  void Get(object ob);
}

class Human{
  int age = 0;
  float weight = 0;
  float height = 0;
  string DefaultLanguage = "";
}
