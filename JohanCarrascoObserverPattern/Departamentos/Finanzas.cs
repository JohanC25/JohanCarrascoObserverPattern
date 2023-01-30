using JohanCarrascoObserverPattern.Subject;

namespace JohanCarrascoObserverPattern.Departamentos
{
    public interface IFinanzas
    {
        void CalcularSalario();
    }

    public class Finanzas : IFinanzas, IResignationObserver
    {
        public Finanzas(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void CalcularSalario()
        {

        }

        public void Notify(string employeeId)
        {
			UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
			xmlHelper.UpdateNotificationDetail("Finanzas", employeeId);
		}
    }
}
