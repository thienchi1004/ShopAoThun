using ShopAoThung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopAoThung.ViewModel
{
	public class infoViewModel
	{
		public List<Models.Cart_item> CartItems { get; set; }
		public Muser Muser { get; set; }
	}
}