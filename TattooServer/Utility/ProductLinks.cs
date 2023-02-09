using Contracts;
using Entities.DataTransferObjects;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System;
using System.Net.Http.Headers;
using Entities.Models;
using System.Linq;

namespace TattooServer.Utility
{
    public class ProductLinks
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IDataShaper<ProductDto> _dataShaper;

        public ProductLinks(LinkGenerator linkGenerator, IDataShaper<ProductDto> dataShaper)
        {
            _linkGenerator = linkGenerator;
            _dataShaper = dataShaper;
        }

        public LinkResponse TryGenerateLinks(IEnumerable<ProductDto> productsDto, string fields, HttpContext httpContext)
        {
            var shapedProducts = ShapeData(productsDto, fields);

            if (ShouldGenerateLinks(httpContext))

                return ReturnLinkdedProducts(productsDto, fields, httpContext, shapedProducts);

            return ReturnShapedProducts(shapedProducts);
        }

        private List<Entity> ShapeData(IEnumerable<ProductDto> productsDto, string fields)
            => _dataShaper.ShapeData(productsDto, fields).Select(e => e.Entity).ToList();


        private bool ShouldGenerateLinks(HttpContext httpContext)
        {
            var mediaType = (MediaTypeHeaderValue)httpContext.Items["AcceptHeaderMediaType"];

            return mediaType.SubTypeWithoutSuffix.EndsWith("hateoas", StringComparison.InvariantCultureIgnoreCase);
        }

        private LinkResponse ReturnShapedProducts(List<Entity> shapedProducts)
            => new LinkResponse { ShapedEntities = shapedProducts };

        private LinkResponse ReturnLinkdedProducts(IEnumerable<ProductDto> productsDto,
            string fields,
            HttpContext httpContext,
            List<Entity> shapedProducts)
        {
            var productDtoList = productsDto.ToList();
            for (var index = 0; index < productDtoList.Count(); index++)
            {
                var productLinks = CreateLinksForProduct(httpContext, productDtoList[index].Id, fields);
                shapedProducts[index].Add("Links", productLinks);
            }
            var productsCollection = new LinkCollectionWrapper<Entity>(shapedProducts);
            var linkedProducts = CreateLinksForProducts(httpContext, productsCollection);
            return new LinkResponse { HasLinks = true, LinkedEntities = linkedProducts };
        }

        private List<Link> CreateLinksForProduct(HttpContext httpContext, Guid id, string fields = "")
        {
            var links = new List<Link>
            {
             new Link(_linkGenerator.GetUriByAction(httpContext, "GetProduct",
            values: new { id, fields }),
             "self",
             "GET"),
             new Link(_linkGenerator.GetUriByAction(httpContext,
            "DeleteProduct", values: new { id }),
             "delete_product",
             "DELETE"),
             new Link(_linkGenerator.GetUriByAction(httpContext,
            "UpdateProduct", values: new { id }),
             "update_product",
             "PUT"),
             new Link(_linkGenerator.GetUriByAction(httpContext,
            "PartiallyUpdateProduct", values: new { id }),
             "partially_update_product",
             "PATCH")
             };
            return links;
        }

        private LinkCollectionWrapper<Entity> CreateLinksForProducts(HttpContext httpContext,
            LinkCollectionWrapper<Entity> productsWrapper)
        {
            productsWrapper.Links.Add(new Link(_linkGenerator.GetUriByAction(httpContext,
           "GetProducts", values: new { }),
            "self",
            "GET"));
            return productsWrapper;
        }

    }
}
