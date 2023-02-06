namespace CoreAPIOld.Services.Interfaces
{
    public interface IBookService
    {
        public bool CompareNames(string name, IDataService _dataServices);
    }
}
