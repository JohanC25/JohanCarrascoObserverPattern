using JohanCarrascoObserverPattern.Departamentos;

namespace JohanCarrascoObserverPattern.Subject
{
	public class Resignation : IResignation
	{
		List<IResignationObserver> observerList;
		public Resignation()
		{
			observerList = new List<IResignationObserver>();
		}

		public void AddObserver(IResignationObserver observer)
		{
			observerList.Add(observer);
		}

		public void NotifyObserver(string employeeId)
		{
			foreach (var observer in observerList)
			{
				observer.Notify(employeeId);
			}
		}

		public void RemoveObserver(IResignationObserver observer)
		{
			observerList.Remove(observer);
		}
	}
}
