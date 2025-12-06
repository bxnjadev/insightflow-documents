using insightflow_documents.Model;

namespace insightflow_documents.Service;

public class DocumentService : IDocumentService
{

    private readonly List<Document> _documents = new List<Document>();
    
    public Document Create(CreationDocument creationDocument)
    {
        throw new NotImplementedException();
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