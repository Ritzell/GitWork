using System;
using GitEngine;

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
  Vector3 position =  new Vector3(0,0,0);

  public Human(string n,int a,float w,float h,string c){
    name = n;
    age = a;
    weight = w;
    height = h;
    country = c;
  }

  public void Walk(Vector3 speed){
    position += speed;
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


class Gunity{
  static void Main(){
    Human man = new Human("Yuji",18,45,161,"japan");
    man.Walk(new Vector3(10,0,0));
    Console.WriteLine(man.position.x);
  }
}
