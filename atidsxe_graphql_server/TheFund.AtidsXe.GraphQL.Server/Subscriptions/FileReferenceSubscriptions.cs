using HotChocolate;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TheFund.AtidsXe.GraphQL.Server.DataLoaders;

namespace TheFund.AtidsXe.GraphQL.Server.Subscriptions
{
    [ExtendObjectType(Name = "Subscription")]
    public class FileReferenceSubscriptions
    {
        [Subscribe(With = nameof(SubscribeToOnFileStatusChangedAsync))]
        public FileStatusChanged OnFileStatusChanged(
           int fileReferenceId,
           [EventMessage] int fileStatusId,
           FileReferenceByIdDataLoader loader,
           CancellationToken cancellationToken)
        {
            return new FileStatusChanged(fileStatusId, fileReferenceId);
        }

        public async ValueTask<IAsyncEnumerable<int>> SubscribeToOnFileStatusChangedAsync(
            int fileReferenceId,
            [Service] ITopicEventReceiver eventReceiver,
            CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, int>("OnFileStatusChanged_" + fileReferenceId, cancellationToken);
        }
    }
}
