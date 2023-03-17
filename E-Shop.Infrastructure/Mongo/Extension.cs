
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace E_Shop.Infrastructure.Mongo
{
    public static class Extension
    {


        public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {

            var configSection = configuration.GetSection("mongo");
             
            var mongoConfig = new MongoConfig();

            configSection.Bind(mongoConfig);

            services.AddSingleton<IMongoClient>(client -> {
                return new MongoClient(mongoConfig.ConnectionString);

            });


        }


    }
}
