﻿using SQLite;

namespace InfiniteRechargeMetrics.Models
{
    [Table("Team")]
    public class Team
    {
        /// <summary>
        ///     The id of the team provided by the user.
        /// </summary>
        [Column("team_id"), PrimaryKey, Unique]
        public string TeamId { get; set; }
        /// <summary>
        ///     The name or title of the team.
        /// </summary>
        [Column("alias")]
        public string Alias { get; set; }        
        [Column("is_home_team")]
        public bool IsHomeTeam { get; set; }
        [Column("image_path")]
        public string ImagePath { get; set; }
    }
}
