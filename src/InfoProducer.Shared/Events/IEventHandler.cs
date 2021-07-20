namespace InfoProducer.Shared.Events
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Handle(T eventObject);
    }
}