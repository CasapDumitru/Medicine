using HealthInsurance.Core.Models;

namespace HealthInsurance.Core.Specifications
{
	public class FullOfficeByIdSpecification : Specification<Office>
	{
		public FullOfficeByIdSpecification(int id)
			: base(office => office.Id == id)
		{
			AddInclude(b => b.Address);
			AddInclude(b => b.Departments);
			AddInclude(b => b.RecievedReviews);
			AddInclude(b => b.Owner);
		}
	}

	public class FullOfficeByNameSpecification : Specification<Office>
	{
		public FullOfficeByNameSpecification(string name)
			: base(office => office.Name.Contains(name))
		{
			AddInclude(b => b.Address);
			AddInclude(b => b.Departments);
			AddInclude(b => b.RecievedReviews);
			AddInclude(b => b.Owner);
		}
	}

	public class OfficeByNameSpecification : Specification<Office>
	{
		public OfficeByNameSpecification(string name)
			: base(office => office.Name.Contains(name))
		{
		}
	}
}
