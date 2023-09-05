using System.Collections.Generic;

namespace graphql_app
{
    public class Query
    {
        public List<Todo> GetTodos()
        {
            Service service = new();
            return service.GetTodos();
        }


        public Invoice GetInvoice()
        {
            return new Invoice { CustomerId = "OLA", InvoiceId = 123, InvoiceNumber = 123 };
        }
    }
}
