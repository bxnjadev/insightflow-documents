using System.Text.Json;

namespace insightflow_documents.Model;

public class CreationDocument
{
    public string Title { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public JsonElement Content { get; set; }

    public int WorkspaceId { get; set; } = 0;

}