using insightflow_documents.Model;

namespace insightflow_documents.Service;

public interface IDocumentService
{
    
    /**
     * Create a new document and store 
     */

    Document Create(CreationDocument creationDocument);

    /**
     * Find a document from her uuid in the storage and retrieve the document founded
     */
    
    Document? Find(string uuid);
    
    /**
     * Using the soft delete tech, remove a document from uuid
     */
    
    Document? Delete(string uuid);
    
    /**
     * Edit a document from uuid
     */

    Document? Edit(string uuid, EditDocument editDocument);

}