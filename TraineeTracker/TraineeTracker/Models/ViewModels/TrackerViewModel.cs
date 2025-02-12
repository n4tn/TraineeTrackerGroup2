﻿using static TraineeTracker.Models.SkillsEnum;

namespace TraineeTracker.Models.ViewModels
{
    public class TrackerViewModel
    {
        public int ID { get; init; }
        public int UserDataId { get; init; }
        public int Week { get; init; }
        public string Stop { get; set; } = "N/A";
        public string Start { get; set; } = "N/A";
        public string Continue { get; set; } = "N/A";
        public string? Comments { get; set; } = "";
        public SkillsRank TechnicalSkills { get; set; }
        public SkillsRank ConsultantSkills { get; set; }
    }
}
