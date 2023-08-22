using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao10_herancaEpolimorfismo.Entities
{
	public sealed class OutsourcedEmployee : Employee
	{
		public double AdditionalCharge { get; set; }
		public OutsourcedEmployee() { }

		public OutsourcedEmployee(double additionalCharge) : base(base)
		{
			AdditionalCharge = additionalCharge;
		}

		public override double payment()
		{
			return base.Payment() + 1.1 * AdditionalCharge;
		}
	}
}
