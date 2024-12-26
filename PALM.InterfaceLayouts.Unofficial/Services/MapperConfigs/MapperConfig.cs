using AutoMapper;
using PALM.InterfaceLayouts.Unofficial.Entities.FlattenedLayouts.PurchaseOrders;
using PALM.InterfaceLayouts.Unofficial.Entities.InterfaceLayouts.PurchaseOrders.InboundEncumbranceLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.Services.MapperConfigs
{
    internal static class MapperConfig
    {
        internal static MapperConfiguration MapperConfiguration = new MapperConfiguration(config =>
        {
            // Purchase Order domain object --> DTO
            config.CreateMap<List<POHeaderDetails>, List<FlattenedPurchaseOrder>>().ConvertUsing(new PurchaseOrderToFlattenedCustomTypeConverter());

            // Purchase Order DTO --> domain object
            config.CreateMap<List<FlattenedPurchaseOrder>, List<POHeaderDetails>>().ConvertUsing(new FlattenedToPurchaseOrderCustomTypeConverter());
        });
        internal static Mapper Mapper = new Mapper(MapperConfiguration);
    }
}
