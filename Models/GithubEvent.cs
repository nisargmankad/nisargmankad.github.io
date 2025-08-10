namespace MyPortfolio.Models
{
  public class GithubEvent
  {
    public string? type { get; set; }
    public DateTime created_at { get; set; }
    public GithubEventPayload? payload { get; set; }
  }
  public class GithubEventPayload
  {
    public int size { get; set; }
    public List<GithubCommit>? commits { get; set; }
  }
  public class GithubCommit
  {
    public string? sha { get; set; }
    public GithubAuthor? author { get; set; }
    public string? message { get; set; }
    public bool? distinct { get; set; }
    public string? url { get; set; }
  }
  public class GithubAuthor
  {
    public string? email { get; set; }
    public string? name { get; set; }
  }
}
