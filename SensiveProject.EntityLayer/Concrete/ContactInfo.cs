using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.EntityLayer.Concrete
{
	public class ContactInfo
	{
		public int ContactInfoId { get; set; }
		public string? City { get; set; }
		public string? CityDescription { get; set; }
		public string? Country { get; set; }
		public string? Phone { get; set; }
		public string? PhoneDescription { get; set; }
		public string? Mail { get; set; }
		public string? MailDescription { get; set; }

		public string? MapUrl{ get; set; }

	}
}
