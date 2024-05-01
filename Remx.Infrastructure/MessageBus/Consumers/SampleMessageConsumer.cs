using MassTransit;
using Remx.Infrastructure.MessageBus.Messages;

namespace Remx.Infrastructure.MessageBus.Consumers;

public class SampleMessageConsumer : IConsumer<SampleMessage>
{
    public async Task Consume(ConsumeContext<SampleMessage> context)
    {
        var message = context.Message;
        
        Console.WriteLine($"**1** Sample Message: {message.Content} - {message}");
        throw new Exception("Simulated error.");
    }
}