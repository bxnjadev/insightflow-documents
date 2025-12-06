using System.Text.Json;

namespace insightflow_documents.Model;

public class Document
{

    public Guid Uuid { get; set; }
    
    public string Title { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public JsonElement Content { get; set; }

    public Guid WorkspaceId { get; set; } 

    public bool IsDeleted { get; set; }

}