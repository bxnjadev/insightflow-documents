using System.Text.Json;

namespace insightflow_documents.Model;

public class Document
{

    /**
     * The uuid for the document
     */
    public Guid Uuid { get; set; }
 
    /**
     * The title document
     */
    
    public string Title { get; set; } = string.Empty;

    /**
     * The icon document
     */
    public string Icon { get; set; } = string.Empty;

    /**
     * The content document 
     */
    public string Content { get; set; } 

    /**
     * The workspace id asocciated the document
     */
    public string WorkspaceId { get; set; } 

    /**
     * Is true if the document is deleted
     */
    
    public bool IsDeleted { get; set; }

}