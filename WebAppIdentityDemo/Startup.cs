﻿using Microsoft.Owin;
using Owin;
using WebAppSoC.Infrastructure.Crosscutting.Security.Startup;

[assembly: OwinStartup("ProductionConfiguration", typeof(WebAppIdentityDemo.Startup))]
namespace WebAppIdentityDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            new IdentityStartup().Configuration(app);
        }
    }
}
