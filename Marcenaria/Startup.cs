﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marcenaria.Startup))]
namespace Marcenaria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
