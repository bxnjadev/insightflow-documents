using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace insightflow_documents.Util;

public class JsonValidator
{
    
    private JsonValidator() {}
    
    public static bool IsValidJson(string jsonString)
    {
        if (string.IsNullOrWhiteSpace(jsonString))
        {
            return false;
        }

        try
        {
            var obj = JToken.Parse(jsonString);
            return true;
        }
        catch (JsonReaderException)
        {
            return false;
        }
    }
    
    public static string FormatJson(string jsonString)
    {
        if (!IsValidJson(jsonString))
        {
            return "{}";
        }

        try
        {
            var obj = JToken.Parse(jsonString);
            return obj.ToString(Formatting.None);
        }
        catch
        {
            return "{}";
        }
    }
    
}