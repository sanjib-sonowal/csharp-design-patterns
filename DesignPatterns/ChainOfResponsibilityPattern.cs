using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /* 
     * Handling Support Requests: We'll create a scenario where we have a chain of support handlers 
     * (e.g., BasicSupportHandler, TechnicalSupportHandler, and BillingSupportHandler) that process 
     * different levels of support requests.
    */

    /*Explanation:
     * SupportRequest Class: Represents a support request, which has a Type (e.g., "Basic", "Technical", "Billing") 
     * and a Description.
     * 
     * SupportHandler Abstract Class: Defines an abstract HandleRequest method and maintains a reference to the next 
     * handler in the chain using the _nextHandler field.
     * 
     * Concrete Handlers (BasicSupportHandler, TechnicalSupportHandler, BillingSupportHandler): These classes inherit 
     * from SupportHandler and provide specific implementations for handling different types of requests. 
     * If a handler cannot process the request, it passes it to the next handler in the chain.
     * 
     * Main Program: The program sets up the chain of responsibility by linking the handlers together. 
     * It then creates support requests and sends them through the chain, where they are handled by the 
     * appropriate handler.
    */

    // Step 1: Define the SupportRequest Class
    public class SupportRequest
    {
        public string Type { get; set; }
        public string Description { get; set; }

        public SupportRequest(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }

    // Step 2: Create the SupportHandler Abstract Class
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;

        public void SetNextHandler(SupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(SupportRequest request);
    }

    // Step 3: Implement Concrete Handlers
    // 1. BasicSupportHandler Class
    public class BasicSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.Type == "Basic")
            {
                Console.WriteLine($"BasicSupportHandler: Handling basic support request - {request.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

    // 2. TechnicalSupportHandler Class
    public class TechnicalSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.Type == "Technical")
            {
                Console.WriteLine($"TechnicalSupportHandler: Handling technical support request - {request.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

    // 3. BillingSupportHandler Class
    public class BillingSupportHandler : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.Type == "Billing")
            {
                Console.WriteLine($"BillingSupportHandler: Handling billing support request - {request.Description}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
