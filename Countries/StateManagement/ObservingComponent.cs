using Microsoft.AspNetCore.Components;

namespace Countries.StateManagement;

public abstract class ObservingComponent : ComponentBase, IDisposable
{
    public List<IDisposable>? Subscriptions { get; set; }

    public void Dispose()
    {
        if (Subscriptions != null)
            foreach (var subscription in Subscriptions)
                subscription.Dispose();
    }

    public void OnNext()
    {
        StateHasChanged();
    }
}