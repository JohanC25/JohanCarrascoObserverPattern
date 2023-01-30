using System.Xml.Linq;

namespace JohanCarrascoObserverPattern.Departamentos
{
	public class UpdateXmlHelper
	{
		public void UpdateNotificationDetail(string department, string employeeId)
		{
			XDocument xDocument = XDocument.Load("wwwroot/NotifiedDepartment.xml");
			XElement dept = xDocument.Element("Departmentos");
			XElement elementFinance = dept.Element(department);
			if (elementFinance == null)
			{
				dept.Add(new XElement(department,
						   new XElement("EmployeeId", employeeId)));
			}
			else
			{
				elementFinance.Add(new XElement("EmployeeId", employeeId));
			}
			xDocument.Save("wwwroot/NotifiedDepartment.xml");
		}
	}
}
