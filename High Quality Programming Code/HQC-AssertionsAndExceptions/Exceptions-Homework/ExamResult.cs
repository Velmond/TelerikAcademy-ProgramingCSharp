﻿//-----------------------------------------------------------------------
// <copyright file="ExamResult.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace ExceptionsHomework
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public ExamResult(int grade, int minGrade, int maxGrade)
            : this(grade, minGrade, maxGrade, string.Empty)
        {
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade connot be less than 0.");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade connot be less than 0.");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade connot be less than 0.");
                }

                if (value < this.MinGrade)
                {
                    throw new ArgumentException("Max grade cannot be less than the minimum one.");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Comments can't be null.");
                }

                this.comments = value;
            }
        }
    }
}
