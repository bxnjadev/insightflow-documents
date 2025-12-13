using System.Text.Json;
using insightflow_documents.Model;

namespace insightflow_documents.Service;

public class DocumentService : IDocumentService
{

    private readonly List<Document> _documents = new List<Document>();
    
    public Document Create(CreationDocument creationDocument)
    {
        var document = new Document
        {
            Uuid = Guid.NewGuid(),
            Title = creationDocument.Title,
            Content = new JsonElement(),
            Icon = creationDocument.Icon,
            WorkspaceId = creationDocument.WorkspaceId
        };
        
        _documents.Add(document);
        return document;
    }

    public Document? Find(string uuid)
    {
        var guid = new Guid(uuid);
        
        foreach(var document in _documents)
        {
            if (document.Uuid == guid)
            {
                
                return document;
            }
        }

        return null;
    }

    public Document? Delete(string uuid)
    {
        var document = Find(uuid);
        if (document == null)
        {
            return null;
        }

        document.IsDeleted = true;
        return document;
    }
}