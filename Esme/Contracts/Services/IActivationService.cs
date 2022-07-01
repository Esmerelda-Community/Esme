using System.Threading.Tasks;

namespace Esme.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
