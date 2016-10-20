using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            DrawingTool drawer = new DrawingTool();
            
            // ShapeA
            Console.WriteLine("Shape A, 10 stars in a row \r\n");

            for (int i = 0; i < 11; i++)
            {
                drawer.DrawOneStar();                
            }

            // ShapeB
            Console.WriteLine("\r\n Shape B, 5 stars in a row, separated by space \r\n");

            for (int i = 0; i < 5; i++)
            {
                drawer.DrawOneStar();
                drawer.DrawOneSpace();
            
            }

            // Shape C
            Console.WriteLine("\r\n Shape C, 10 rows with 10 starts in each \r\n");

            for (int i = 0; i < 10; i++)
            {
                
                drawer.DrawOneStar();
                drawer.StartNewLine();  
            }
            // YOUR JOB: Add code to draw shapes


            // The LAST line of code should be ABOVE this line
        }
    }
}
