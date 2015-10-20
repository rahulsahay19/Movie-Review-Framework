namespace Movie_Review_Framework.Domain
{
    public class MovieReview
    {
        public MovieReview(string reviewerName,string reviewerComments,int reviewerRating)
        {
            ReviewerName = reviewerName;
            ReviewerComments = reviewerComments;
            ReviewerRating = reviewerRating;
        }
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerComments { get; set; }
        public int ReviewerRating { get; set; }
        public int MovieId { get; set; }
    }
}