using System;

namespace Saga.Repository
{
    public class BasketDto
    {
        public Guid TransactionNumber { get; set; }
        public int NumberOfPassenger { get; set; }
        public int Domain { get; set; }
        public int AgentId { get; set; }
        public string ReferrerUrl { get; set; }
        public DateTime CreatedDataTime { get; set; }
        public int UserId { get; set; }
        public string SelectedCurrency { get; set; }
        public string ReservationSystem { get; set; }
    }
}