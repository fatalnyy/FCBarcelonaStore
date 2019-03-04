using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCBarcelonaStore.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Items.Any())
            {
                context.AddRange
               (
                new TShirt { Name = "2018/19 FC Barcelona Stadium Home TShirt", ShortDescription = "Men's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 59.99M, Gender = 'M', Size = "L", Discount = false, ImageUrl = "~/images/items/tshirt1.png", ImageThumbnailUrl = "~/images/items/tshirt1T.jpg" },
                new TShirt { Name = "2018/19 FC Barcelona Stadium Home TShirt", ShortDescription = "Women's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Women's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 59.99M, Gender = 'F', Size = "S", Discount = false, ImageUrl = "~/images/items/tshirt2.png", ImageThumbnailUrl = "~/images/items/tshirt2T.jpg" },
                new Pants { Name = "2018/19 FC Barcelona Stadium Home Shorts", ShortDescription = "Men's Football Shorts", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shorts are made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on the pitch.", Price = 29.99M, Gender = 'M', Size = "M", Discount = true, ImageUrl = "~/images/items/shorts1.jpg", ImageThumbnailUrl = "~/images/items/shorts1T.jpg" },
                new Item { Name = "FC Barcelona Backpack", ShortDescription = "Football Backpack", LongDescription = "The FC Barcelona Stadium Football Backpack features padded, adjustable shoulder straps and multiple compartments for comfortable carrying and organised storage.", Price = 19.99M, Discount = true, ImageUrl = "~/images/items/backpack1.jpg", ImageThumbnailUrl = "~/images/items/backpack1T.jpg" },
                new Item { Name = "FC Barcelona Ball", ShortDescription = "Football", LongDescription = "he FC Barcelona Strike Football is ready for everyday play with a reinforced rubber bladder and high-contrast graphics for a consistent feel and easy visual tracking.", Price = 9.99M, Discount = false, ImageUrl = "~/images/items/ball1.jpg", ImageThumbnailUrl = "~/images/items/ball1T.jpg" },
                new TShirt { Name = "2018/19 FC Barcelona Stadium Away TShirt", ShortDescription = "Men's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 29.99M, Gender = 'M', Size = "XL", Discount = true, ImageUrl = "~/images/items/tshirt3.png", ImageThumbnailUrl = "~/images/items/tshirt3T.jpg" },
                new Item { Name = "FC Barcelona Stadium", ShortDescription = "Kids' Football Backpack", LongDescription = "The FC Barcelona Stadium Kids' Football Backpack features a spacious main compartment and padded, adjustable shoulder straps so you can comfortably carry your essentials.", Price = 12.99M, Discount = false, ImageUrl = "~/images/items/backpack2.png", ImageThumbnailUrl = "~/images/items/backpack2T.jpg" },
                new Item { Name = "FC Barcelona Stars", ShortDescription = "Scarf", LongDescription = "The FC Barcelona Stars Scarf helps you stay warm and show your support with soft fabric and premium team details.", Price = 9.99M, Discount = true, ImageUrl = "~/images/items/scarf1.png", ImageThumbnailUrl = "~/images/items/scarf1T.jpg" },
                new Pants { Name = "2018/19 FC Barcelona Stadium Away", ShortDescription = "Home/Away Men's Football Shorts", LongDescription = "The 2018/19 FC Barcelona Stadium Away Men's Football Shorts are made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on the pitch.", Price = 29.99M, Gender = 'M', Size = "XL", Discount = false, ImageUrl = "~/images/items/shorts2.png", ImageThumbnailUrl = "~/images/items/shorts2T.jpg" },
                new TShirt { Name = "2018/19 FC Barcelona Stadium Away TShirt", ShortDescription = "Men's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 59.99M, Gender = 'M', Size = "XL", Discount = true, ImageUrl = "~/images/items/tshirt4.png", ImageThumbnailUrl = "~/images/items/tshirt4T.jpg" },
                new TShirt { Name = "FC Barcelona 20th Anniversary", ShortDescription = "Momen's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Women's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 39.99M, Gender = 'F', Size = "XL", Discount = false, ImageUrl = "~/images/items/tshirt5.png", ImageThumbnailUrl = "~/images/items/tshirt5T.jpg" },
                new TShirt { Name = "2018/19 FC Barcelona Stadium Third", ShortDescription = "Men's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 49.99M, Gender = 'M', Size = "XL", Discount = false, ImageUrl = "~/images/items/tshirt6.png", ImageThumbnailUrl = "~/images/items/tshirt6T.jpg" }
               );

                context.SaveChanges();
            }
        }
    }
}
