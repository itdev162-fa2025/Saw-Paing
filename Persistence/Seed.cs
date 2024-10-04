using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus faucibus sagittis turpis, ac laoreet sapien. Vivamus fermentum nulla sed ligula sodales pellentesque	",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second post",
                        Body = "Integer quis mi nunc. Donec quis efficitur augue. Vestibulum quis mollis odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post {
                        Title = "Third post",
                        Body = "Morbi et orci nisl. Sed mollis turpis a turpis imperdiet, vitae elementum elit egestas. Lorem ipsum dolor sit amet, consectetur adipiscing	",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}