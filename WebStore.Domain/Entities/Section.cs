﻿using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
	public class Section : NamedEntyty, IOrderedEntity
	{
		public int? ParentId { get; set; }
		public int Order { get; set; }
	}
}
