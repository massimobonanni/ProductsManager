namespace ProductsManager.FunAPIClient.Dto
{
    public abstract class DtoBase<TEntity> where TEntity : class
    {
        public DtoBase()
        {

        }
        public DtoBase(TEntity entity)
        {

        }

        public abstract TEntity ToEntity();
    }
}