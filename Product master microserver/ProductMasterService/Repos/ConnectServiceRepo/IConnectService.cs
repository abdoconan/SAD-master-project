namespace ProductMasterService
{
    public interface IConnectService
    {
        public Task<List<ProductDTO>> getProduct();
    }
}