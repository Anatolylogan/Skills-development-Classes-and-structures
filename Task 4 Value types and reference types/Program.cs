using System;
namespace Task_4_Value_types_and_reference_types
{
 class Program
 {
  static void Main()
  {
   PointStruct structPoint1 = new PointStruct { X = 10, Y = 20 };
   PointStruct structPoint2 = structPoint1;

   structPoint2.X = 50;

   Console.WriteLine($"structPoint1: X = {structPoint1.X}, Y={structPoint1.Y}");
   Console.WriteLine($"structPoint2: X = {structPoint2.X}, Y={structPoint2.Y}");
            
   PointClass classPoint1 = new PointClass { X = 10, Y = 20 };
   PointClass classPoint2 = classPoint1;

   classPoint2.X = 50;

   Console.WriteLine($"classPoint1: X={classPoint1.X} Y={classPoint1.Y}");
   Console.WriteLine($"classPoint2^ X={classPoint2.X} Y={classPoint2.Y}");
  }
 }
}