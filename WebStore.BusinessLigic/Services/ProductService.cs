using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.BusinessLogic.DTO.Product;
using WebStore.BusinessLogic.Services.Base;
using WebStore.DataAccess.Repositories.Base;

namespace WebStore.BusinessLogic.Services
{
    public class ProductService
        : IProductService
    {
        IProductRepository productRepository = null;
        IMapper mapper = null;

        public ProductService(IProductRepository _productRepository, IMapper _mapper)
        {
            productRepository = _productRepository;
            mapper = _mapper;
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return productRepository.GetProducts().Select(mapper.Map<ProductDTO>).ToArray();
        }
    }
}
