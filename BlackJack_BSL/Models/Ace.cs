﻿using System;
using BlackJack_BSL.Interfaces;
using Common.Enums;

namespace BlackJack_BSL.Models
{
    public class Ace : Card, Interfaces.Models.IAce
    {
        public int SpecialCost { get; set; } = 1;
        public bool IsSpecialOn { get; set; } = false;

        public Ace(CardRanks.CardRank rank, CardSuits.CardSuit suit) : base(rank, suit) { }

        public int GetSpecialCostDifference()
        {
            return this.Cost - this.SpecialCost;
        }
    }
}