using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningNavigator.Models
{
    public class LearningNavigatorModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        public string SectionName { get; set; }

        public string Category { get; set; }
    }
}
