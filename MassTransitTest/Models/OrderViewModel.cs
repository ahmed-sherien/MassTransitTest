using System.ComponentModel.DataAnnotations;

namespace MassTransitTest.Models
{
    public class OrderViewModel
    {
        [Display(Name = "Name:")]
        public string PickupName { get; set; }
        [Display(Name = "Address:")]
        public string PickupAddress { get; set; }
        [Display(Name = "City:")]
        public string PickupCity { get; set; }
        [Display(Name = "Name:")]

        public string DeliverName { get; set; }
        [Display(Name = "Address:")]
        public string DeliverAddress { get; set; }
        [Display(Name = "City:")]
        public string DeliverCity { get; set; }
        [Display(Name = "Weight:")]

        public int Weight { get; set; }
        [Display(Name = "Fragile:")]
        public bool Fragile { get; set; }
        [Display(Name = "Oversized:")]
        public bool Oversized { get; set; }
    }
}
