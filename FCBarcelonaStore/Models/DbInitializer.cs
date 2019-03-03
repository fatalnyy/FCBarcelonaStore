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
                new TShirt { Name = "2018/19 FC Barcelona Stadium Home TShirt", ShortDescription = "Men's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 59.99M, Gender = 'M', Size = "L", Discount = false, ImageUrl = "https://render.nikeid.com/ir/render/nikeidrender/FCB_MENS_HS_1805_v1?obj=/s/g1&show&obj=/s&req=object&fmt=png-alpha&icc=AdobeRGB&wid=1024", ImageThumbnailUrl = "https://images.nike.com/is/image/DotCom/pwp_sheet2?$NIKE_PWPx3$&$img0=894430_456" },
                new TShirt { Name = "2018/19 FC Barcelona Stadium Home TShirt", ShortDescription = "Women's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Women's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 59.99M, Gender = 'F', Size = "S", Discount = false, ImageUrl = "https://render.nikeid.com/ir/render/nikeidrender/FCB_WMNS_HS_1805_v1?obj=/s/g1&show&obj=/s&req=object&fmt=png-alpha&icc=AdobeRGB&wid=512", ImageThumbnailUrl = "https://images.nike.com/is/image/DotCom/pwp_sheet2?$NIKE_PWPx3$&$img0=894447_456" },
                new Pants { Name = "2018/19 FC Barcelona Stadium Home Shorts", ShortDescription = "Men's Football Shorts", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shorts are made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on the pitch.", Price = 29.99M, Gender = 'M', Size = "M", Discount = true, ImageUrl = "https://c.static-nike.com/a/images/f_auto,b_rgb:f5f5f5,w_440/no4tjffa7dosgfkshzjw/2018-19-fc-barcelona-stadium-home-football-shorts-TqHN1J.jpg", ImageThumbnailUrl = "https://images.nike.com/is/image/DotCom/pwp_sheet2?$NIKE_PWPx3$&$img0=894441_451" },
                new Item { Name = "FC Barcelona Backpack", ShortDescription = "Football Backpack", LongDescription = "The FC Barcelona Stadium Football Backpack features padded, adjustable shoulder straps and multiple compartments for comfortable carrying and organised storage.", Price = 19.99M, Discount = true, ImageUrl = "https://c.static-nike.com/a/images/f_auto,b_rgb:f5f5f5,w_440/vzvqaj4vbt8j9ru1fngq/fc-barcelona-stadium-football-backpack-CBfbvq.jpg", ImageThumbnailUrl = "https://images.nike.com/is/image/DotCom/pwp_sheet2?$NIKE_PWPx3$&$img0=BA5363_451" },
                new Item { Name = "FC Barcelona Ball", ShortDescription = "Football", LongDescription = "he FC Barcelona Strike Football is ready for everyday play with a reinforced rubber bladder and high-contrast graphics for a consistent feel and easy visual tracking.", Price = 9.99M, Discount = false, ImageUrl = "https://c.static-nike.com/a/images/f_auto,b_rgb:f5f5f5,w_880/qwaopxua4b9rivqar4ci/fc-barcelona-prestige-football-k1wGtG.jpg", ImageThumbnailUrl = "https://images.nike.com/is/image/DotCom/pwp_sheet2?$NIKE_PWPx3$&$img0=SC3283_455" },
                new TShirt { Name = "2018/19 FC Barcelona Stadium Away TShirt", ShortDescription = "Men's Football Shirt", LongDescription = "The 2018/19 FC Barcelona Stadium Home Men's Football Shirt is made from breathable, sweat-wicking fabric to help keep you cool, dry and comfortable on and off the pitch.", Price = 29.99M, Gender = 'M', Size = "XL", Discount = true, ImageUrl = "https://render.nikeid.com/ir/render/nikeidrender/FCB_MENS_AS_1806_v1?obj=/s/g1&show&obj=/s&req=object&fmt=png-alpha&icc=AdobeRGB&wid=512", ImageThumbnailUrl = "https://images.nike.com/is/image/DotCom/pwp_sheet2?$NIKE_PWPx3$&$img0=918990_703" }
               );

                context.SaveChanges();
            }
        }
    }
}
