using System;

namespace GitEngine{
  publics class Vector3{
    public float x,y,z;
    public Vector3(float _x,float _y,float _z){
      x = _x;
      y = _y;
      z = _z;
    }

    public static Vector3 operator +(Vector3 op1,Vector3 op2){
      Vector3 v3 = new Vector3(0,0,0);
      v3.x = op1.x + op2.x;
      v3.y = op1.y + op2.y;
      v3.z = op1.z + op2.z;
      return v3;
    }
  }
}
