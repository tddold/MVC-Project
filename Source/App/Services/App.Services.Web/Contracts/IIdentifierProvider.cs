namespace App.Services.Web.Contracts
{
    public interface IIdentifierProvider : IService
    {
        int DecodeId(string urlId);

        string EncodeId(int id);
    }
}
