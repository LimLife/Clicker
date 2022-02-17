public interface IMediator 
{
    void Send(IEntity entity,in ClickData data);//message
}
