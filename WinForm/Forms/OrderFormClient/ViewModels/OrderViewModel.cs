namespace WinForm.Forms.OrderFormClient.ViewModels
{
    internal class OrderViewModel
    {
       public int OrderID { get; set; } 
        public decimal OrderPrice { get; set; }
        public string OrderAddress { get; set; }
        public string OrderDescription { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; } = "pending";
        public int UserId { get; set; } = 3;
    }
}
