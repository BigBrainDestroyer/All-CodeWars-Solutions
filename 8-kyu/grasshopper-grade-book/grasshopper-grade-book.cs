using System;
​
public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    double Average = ((double)s1 + (double)s2 + (double)s3) / 3;
    
    switch(Average)
      {
        case  >= 90:
          return 'A';
        
        case  >= 80:
          return 'B';
        
        case  >= 70:
          return 'C';
        
        case  >= 60:
          return 'D';   
        
        default:
          return 'F';
      }
  }
}