namespace ActionCzernowitz.DAL.Interfaces
{
    internal interface IEntity<T>
    {
        T Id { get; set; }
    }
}
