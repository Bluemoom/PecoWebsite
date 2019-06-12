using AutoMapper;
using PecoWeb.Model.Models;
using PecoWeb.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecoWeb.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configuration()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}