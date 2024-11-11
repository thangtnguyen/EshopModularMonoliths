﻿
using MassTransit;
using Shared.Messaging.Events;

namespace Catalog.Products.EventHandlers
{
    internal class ProductPriceChangedEventHandler(IBus bus, ILogger<ProductPriceChangedEventHandler> logger)
        : INotificationHandler<ProductPriceChangedEvent>
    {
        public async Task Handle(ProductPriceChangedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);
            
            //TODO: publish product price changed integration event for update basket prices
            var integrationEvent = new ProductPriceChangedIntegrationEvent
            {
                ProductId = notification.Product.Id,
                Name = notification.Product.Name,
                Category = notification.Product.Category,
                Description = notification.Product.Description,
                ImageFile = notification.Product.ImageFile,
                Price = notification.Product.Price
            };
            
            await bus.Publish(integrationEvent, cancellationToken);
        }
    }
}
