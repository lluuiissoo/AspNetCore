using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AspNetCore_QOTD
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                IQuoteService quoteService = new QuoteService();

                return context.Response.WriteAsync(quoteService.GetRandomQuote());
            });
        }
    }
}
