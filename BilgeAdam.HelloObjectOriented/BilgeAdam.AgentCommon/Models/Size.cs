namespace BilgeAdam.AgentCommon.Models
{
    public class Size
    {
        public decimal Chest { get; set; }//göğüs
        public decimal Waist { get; set; }//bel
        public decimal Hips { get; set; }//basen

        public override string ToString()
        {
            return $"{Chest} - {Waist} - {Hips}";
        }
    }
}
