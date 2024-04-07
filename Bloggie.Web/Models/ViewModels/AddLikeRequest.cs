namespace Bloggie.Web.Models.ViewModels
{
    public class AddLikeRequest
    {
        public Guid UserId { get; set; }
        public Guid BlogPostId { get; set; }
    }

}
