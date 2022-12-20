using System;
namespace Practice.Models
{
	public class Order
	{
		public int Price { get; set; }
		public DateTime Date { get; set; }

		public Order(int price, DateTime date)
		{
			Price = price;
			Date = date;
		}
	}
}