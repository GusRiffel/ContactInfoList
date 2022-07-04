using ContactInfo.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactInfo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContactInfoContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<ContactInfoContext>>()))
            {
                // Look for any movies.
                if (context.Contact.Any())
                {
                    return;   // DB has been seeded
                }

                context.Contact.AddRange(
                    new Contact
                    {
                        Name = "Daniel",
                        Company = "Starbucks",
                        Email = "dany.dany@yahoo.com",
                        number = 44556677
                    },

                    new Contact
                    {
                        Name = "Kelvin",
                        Company = "Facebook",
                        Email = "kelvito.kerubin@hotmail.com",
                        number = 77665544
                    },

                    new Contact
                    {
                        Name = "Carlos",
                        Company = "Jameson's",
                        Email = "carlos.carl@gmail.com",
                        number = 66447755
                    },

                    new Contact
                    {
                        Name = "Victor",
                        Company = "HSBC",
                        Email = "victor.vic@yahoo.com",
                        number = 77445566
                    }
                );
                context.SaveChanges();
            }
        }
    }
}