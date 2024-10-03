using LearningNavigator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LearningNavigator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningNavigatorController : ControllerBase
    {
        private LearningNavigatorModel learningNavigatorModel;
        /// <summary>
        /// Constructor of LearningNavigatorController
        /// </summary>
        public LearningNavigatorController(LearningNavigatorModel model)
        {
            learningNavigatorModel = model;
        }

        public List<LearningNavigatorModel> GetLearningNavigatorModels()
        {
            var result = new List<LearningNavigatorModel>();
            result.Add(new LearningNavigatorModel()
            {
                Id = 1,
                Category = "IT",
                SectionName = "A",
                CourseName = "learn database"
            });
            return result;
        }
    }
}
