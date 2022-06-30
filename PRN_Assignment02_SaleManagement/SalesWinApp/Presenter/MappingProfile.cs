using AutoMapper;
using BusinessObject;
using DataAccess.Repository.CategoryRepo;
using DataAccess.Repository.MemberRepo;
using DataAccess.Repository.OrderDetailRepo;
using DataAccess.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.Presenter
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping Member
            CreateMap<Member, MemberPresenter>();
            CreateMap<MemberPresenter, Member>();

            // Mapping Product
            CreateMap<Product, ProductPresenter>()
                .ForMember(des => des.CategoryName,
                                act => act.MapFrom(src => src.Category.CategoryName));
            ICategoryRepository categoryRepository = new CategoryRepository();
            CreateMap<ProductPresenter, Product>()
                .ForMember(des => des.CategoryId,
                                act => act.MapFrom(src => categoryRepository.GetCategory(src.CategoryName).CategoryId));

            // Mapping Order
            IMemberRepository memberRepository = new MemberRepository();
            IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            CreateMap<Order, OrderPresenter>()
                 .ForMember(des => des.OrderTotal,
                                act => act.MapFrom(src => orderDetailRepository.GetOrderTotal(src.OrderId)))
                 .ForMember(des => des.MemberName,
                                act => act.MapFrom(src => memberRepository.GetMember(src.MemberId).Fullname));

            // Mapping OrderDetail to CartItem
            IProductRepository productRepository = new ProductRepository();
            CreateMap<OrderDetail, CartPresenter>()
                  .ForMember(des => des.ProductName,
                                act => act.MapFrom(src => productRepository.GetProduct(src.ProductId, null).ProductName))
                  .ForMember(des => des.Price,
                                act => act.MapFrom(src =>
                                    (productRepository.GetProduct(src.ProductId, null).UnitPrice) * (1 - Convert.ToDecimal(src.Discount))))
                  .ForMember(des => des.Quantity,
                                act => act.MapFrom(src => src.Quantity))
                  .ForMember(des => des.Total,
                                act => act.MapFrom(src =>
                                    (productRepository.GetProduct(src.ProductId, null).UnitPrice) * (1 - Convert.ToDecimal(src.Discount)) * src.Quantity));

            // Mapping Order to AdminOrderPresenter
            //IMemberRepository memberRepository = new MemberRepository();
            //CreateMap<Order, AdminOrderPresenter>()
            //     .ForMember(des => des.OrderTotal,
            //                    act => act.MapFrom(src => orderDetailRepository.GetOrderTotal(src.OrderId)))
            //     .ForMember(des => des.MemberName,
            //                    act => act.MapFrom(src => memberRepository.GetMember(src.MemberId)));

        }
    }
}
