using JohanCarrascoObserverPattern.Subject;

namespace JohanCarrascoObserverPattern.Departamentos
{
    public interface IAsset
    {
        void AllocateAsset();
    }

    public class IT : IAsset, IResignationObserver
    {
		public IT(IResignation resignation)
		{
			resignation.AddObserver(this);
		}

		public void AllocateAsset()
        {

        }

		public void Notify(string employeeId)
		{
			UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
			xmlHelper.UpdateNotificationDetail("IT", employeeId);
		}
	}
}
