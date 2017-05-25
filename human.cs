using System;

interface IHuman{
  void Walk(float speed);
  void Speak(string text);
  string listen();
  void Run(float speed);
  void Get(object ob);
}

class Human : IHuman{
  string name = "";
  int age = 0;
  float weight = 0;
  float height = 0;
  string country = "";

  public Human(string n,int a,float w,float h,string c){
    name = n;
    age = a;
    weight = w;
    height = h;
    country = c;
  }

  public void Walk(float speed){

  }

  public void Speak(string text){
    Console.WriteLine(text);
  }

  public string listen(){
    string str = Console.Read();
    return str;
  }

  public void Run(float speed){

  }

  public void Get(object ob){

  }

}
