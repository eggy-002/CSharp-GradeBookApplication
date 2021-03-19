﻿using System;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook
   {
      public RankedGradeBook(string name) : base(name)
      {
         Type = Enums.GradeBookType.Ranked;
      }

      public override char GetLetterGrade(double averageGrade)
      {
         if(Students.Count < 5)
            throw new InvalidOperationException();

         if (averageGrade >= 80)
            return 'A';
         else if (averageGrade >= 60)
            return 'B';
         else if (averageGrade >= 40)
            return 'C';
         else if (averageGrade >= 20)
            return 'D';
         else
            return 'F';
      }

      public override void CalculateStatistics()
      {
         if (Students.Count < 5)
         {
            Console.WriteLine
               ("Ranked grading requires at lease 5 students with grades in" +
               "order to properly calculate a student's overall grade.");
         }
         else
         {
            base.CalculateStatistics();
         }


      }
   }
}
