using insightflow_documents.Mapper;
using insightflow_documents.Model;
using insightflow_documents.Service;
using Microsoft.AspNetCore.Mvc;

namespace insightflow_documents.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentController(IDocumentService documentService) : ControllerBase
{

    private readonly DocumentMapper _documentMapper = new DocumentMapper();

    [HttpPost]
    [Route("/documents")]
    public ActionResult<DocumentResponse> Post([FromBody] CreationDocument creationDocument)
    {
        var documentCreated = documentService.Create(creationDocument);
        return Ok(
                _documentMapper.Map(documentCreated)
            );
    }

    [HttpGet]
    [Route("/documents/{id}")]
    public ActionResult<DocumentResponse> Find(string id)
    {

        var document = documentService.Find(id);
        if (document == null)
        {
            return NotFound("Element not found");
        }

        return Ok(_documentMapper.Map(document));
    }

    [HttpPatch]
    [Route("/documents/{id}")]
    public ActionResult<DocumentResponse> Edit(string id)
    {
        
    }

    [HttpDelete]
    [Route("/documents/{id}")]
    public ActionResult<DocumentResponse> Delete(string id)
    {
        var document = documentService.Delete(id);
        if (document == null)
        {
            return NotFound("Element not found");
        }

        return Ok(_documentMapper.Map(document));
    }
    
}
