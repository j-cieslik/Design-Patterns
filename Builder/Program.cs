// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

var builder = new InvoiceBuilder();

var invoice = builder.SetDate(new DateTime(2020, 1,1))
            .SetInvoiceNumber("A1")
            .SetVendor("Google...")
            .SetVendee("Vendee")
            .SetLineItems(new List<string>() { "Line item1", "Line item2" })
            .Build();

Console.WriteLine(invoice.Vendee);
Console.WriteLine(invoice.Vendor);