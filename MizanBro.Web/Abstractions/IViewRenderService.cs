using System.Threading.Tasks;

namespace MizanBro.Web.Abstractions
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}