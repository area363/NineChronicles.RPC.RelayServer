﻿namespace NineChronicles.RPC.Server.Store.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EquipmentRankingRingModel
    {
        [Key]
        public string? ItemId { get; set; }

        public string? AvatarAddress { get; set; }

        public string? AgentAddress { get; set; }

        public int EquipmentId { get; set; }

        public int Cp { get; set; }

        public int Level { get; set; }

        public string? ItemSubType { get; set; }

        public string? Name { get; set; }

        public int? AvatarLevel { get; set; }

        public int? TitleId { get; set; }

        public int? ArmorId { get; set; }

        public int Ranking { get; set; }
    }
}