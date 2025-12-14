using insightflow_documents.Model;

namespace insightflow_documents.Mapper;

public class DocumentMapper
{

    public DocumentResponse Map(Document document)
    {
        return new DocumentResponse
        {
            Uuid = document.Uuid,
            Title = document.Title,
            Icon = document.Icon,
            Content = document.Content,
            WorkspaceId = document.WorkspaceId
        };
    }
    
}