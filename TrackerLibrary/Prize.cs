using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class Prize
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public int PlaceNumber { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public Prize()
        {

        }
        /// <summary>
        /// Overloaded constructor
        /// For usage of parsing Prize properties only for once
        /// </summary>
        public Prize(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
