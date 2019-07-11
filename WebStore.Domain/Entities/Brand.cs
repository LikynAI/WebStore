using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
	public class Brand : NamedEntyty, IOrderedEntity
	{
		public int Order { get; set; }
		public int ProductCount { get; set; }
	}
}
