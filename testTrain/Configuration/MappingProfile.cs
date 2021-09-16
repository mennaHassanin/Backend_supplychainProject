using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testTrain.Model;
using testTrain.Model.ViewModels;
namespace testTrain.Configuration
{
    public class MappingProfile : Profile
    {


        public MappingProfile()
        {

            CreateMap<DelieveryMan, DisplayDeliveryManVM>();
            CreateMap<CreateDeliveryManVM, DelieveryMan>();

        }
    }
}
