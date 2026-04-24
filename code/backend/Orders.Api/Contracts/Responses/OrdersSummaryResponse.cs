namespace Orders.Api.Contracts.Responses
{
    public class OrdersSummaryResponse
    {
        public int Pending { get; set; }

        public int Confirmed { get; set; }

        public int Cancelled { get; set; }
    }
}
