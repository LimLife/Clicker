public interface IEntity
{
    IMediator _mediator { get; }  
    void Notify(ClickData data);
}
