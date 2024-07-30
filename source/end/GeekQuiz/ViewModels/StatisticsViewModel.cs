﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekQuiz.ViewModels
{
    public class StatisticsViewModel
    {
        [DisplayName("Total")]
        public int TotalAnswers { get; set; }

        [DisplayName("Correct")]
        public int CorrectAnswers { get; set; }

        [DisplayName("Incorrect")]
        public int IncorrectAnswers { get; set; }

        [DisplayName("Correct p/user")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public float CorrectAnswersAverage { get; set; }

        [DisplayName("Incorrect p/user")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public float IncorrectAnswersAverage { get; set; }

        [DisplayName("Total p/user")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public float TotalAnswersAverage { get; set; }
    }
}