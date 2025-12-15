using insightflow_documents.Mapper;
using insightflow_documents.Model;
using insightflow_documents.Service;
using insightflow_documents.Util;
using Microsoft.AspNetCore.Mvc;

namespace insightflow_documents.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentController(IDocumentService documentService) : ControllerBase
{
    private readonly DocumentMapper _documentMapper = new DocumentMapper();

    /**
     * Post a new document from http request
     */
    
    [HttpPost]
    [Route("/documents")]
    public ActionResult<DocumentResponse> Post([FromBody] CreationDocument creationDocument)
    {
        try
        {
            var documentCreated = documentService.Create(creationDocument);
            return Ok(
                _documentMapper.Map(documentCreated)
            );
        }
        catch (FormatException e)
        {
            return BadRequest("The uuid format is not vlaid");
        }
    }
    
    /**
     * Find by uuid the document
     */

    [HttpGet]
    [Route("/documents/{id}")]
    public ActionResult<DocumentResponse> Find(string id)
    {
        try
        {
            var document = documentService.Find(id);

            if (document == null)
            {
                return NotFound("Element not found");
            }

            return Ok(_documentMapper.Map(document));
        }
        catch (FormatException e)
        {
            return BadRequest("The uuid format is not valid");
        }
    }
    
    /**
     * Edit a document from her uuiid
     */

    [HttpPut]
    [Route("/documents/{id}")]
    public ActionResult<DocumentResponse> Edit(string id,
        EditDocument editDocument)
    {

        var content = editDocument.Content;
        if (content != "")
        {
            if (!JsonValidator.IsValidJson(content))
            {
                return BadRequest("El contenido no sigue el formato JSON");
            }
        }
        
        try
        {
            var editedDocument = documentService.Edit(id, editDocument);
            if (editedDocument == null)
            {
                return NotFound("Document not found");
            }

            return Ok(editedDocument);
        }
        catch (FormatException e)
        {
            return BadRequest("The uuid format is not valid");
        }
        
    }

    /**
     * Delete a document from uud
     */
    
    [HttpDelete]
    [Route("/documents/{id}")]
    public ActionResult<DocumentResponse> Delete(string id)
    {
        try
        {
            var document = documentService.Delete(id);
            if (document == null)
            {
                return NotFound("Element not found");
            }

            return Ok(_documentMapper.Map(document));
        }
        catch (FormatException e)
        {
            return BadRequest("The uuid format is not valid");
        }
    }
}