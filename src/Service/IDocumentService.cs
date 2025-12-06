using insightflow_documents.Model;

namespace insightflow_documents.Service;

public interface IDocumentService
{

    Document Create(CreationDocument creationDocument);

    Document? Find(string uuid);
    
    Document? Delete(string uuid);

}